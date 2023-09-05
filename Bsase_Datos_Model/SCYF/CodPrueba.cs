using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bsase_Datos_Model.SCYF
{
   public  class CodPrueba
    {
        public OperationResult GetFileScyfFtp(string _UserFtp, string _PasswordFtp, string _User)
        {
            OperationResult _Response = new OperationResult();
            ListFilesFtpResponseDTO _ListFilesFTP = new ListFilesFtpResponseDTO();
            NameFileResponseDTO _NameFile = new NameFileResponseDTO();
            string _NamesFiles = string.Empty;
            List<string> _ListFilesNames = new List<string>();
            ListFilesFtpResponseDTO _Response1 = new ListFilesFtpResponseDTO();
            RepositoryApiSase _RepoApiSase = new RepositoryApiSase();
            try
            {
                StreamReader reader = null;
                FtpWebResponse response = null;
                FtpWebRequest _Request = (FtpWebRequest)WebRequest.Create("ftp://casedbsql.cloudapp.net/");
                _Request.Method = WebRequestMethods.Ftp.ListDirectory;
                _Request.KeepAlive = false;
                _Request.Credentials = new NetworkCredential(_UserFtp, _PasswordFtp);
                response = (FtpWebResponse)_Request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                reader = new StreamReader(responseStream);
                while (true)
                {
                    if (string.IsNullOrEmpty(_NamesFiles = reader.ReadLine()))
                    {
                        break;
                    }
                    _ListFilesNames.Add(_NamesFiles);
                }
                _Response1.Files = _ListFilesNames.ToList();
                _Response1.Files = _Response1.Files.OrderByDescending(x => x).Where(x => !x.Contains("resultado") && x.Contains("reporteAltasMediAccess")).ToList();
                reader.Close();
                response.Close();
                FileFTPDTO _File = GetFileNameSCYF(_Response1.Files);
                _Response = DownloadFile(_File.Nombre, _UserFtp, _PasswordFtp);
                string _Path = @"C:\TempSCYF";
                string FullPath = @"C:\TempSCYF" + "\\" + _File.Nombre;
                DirectoryInfo di = new DirectoryInfo(_Path);
                FileInfo[] _Files = di.GetFiles("*.txt");
                FileScyfFtp _SaveFile = new FileScyfFtp();
                foreach (FileInfo file in _Files)
                {
                    using (var sr = new StreamReader(FullPath, Encoding.Default))
                    {
                        _SaveFile.NombreArchivo = file.Name;
                        _SaveFile.Fecha = DateTime.Now;
                        _SaveFile.ContentFile = sr.ReadToEnd();
                        _SaveFile.Estatus = EstatusSCYF.PedientedeProcesar;
                        _SaveFile.UserInsert = _User;
                    }
                }
                _RepoApiSase.AddSase(_SaveFile);
                string txtNameFile = _SaveFile.NombreArchivo.Replace(".txt", "Resultado");
                txtNameFile = txtNameFile + ".txt";
                string texto = string.Empty;
                int Id = _SaveFile.Id;
                List<LayoutSCYFModel> _ListLayout = new List<LayoutSCYFModel>();
                List<DetalleSCYF> _ListDetalle = new List<DetalleSCYF>();
                foreach (string line in File.ReadLines(FullPath))
                {
                    string[] listContent = line.Split(',');

                    _ListDetalle.Add(new DetalleSCYF()
                    {
                        IdFile = Id,
                        CodProducto = listContent[0].Trim(),
                        NomProducto = listContent[1],
                        CodEmpresa = Convert.ToInt32(listContent[2]),
                        Empresa = listContent[3],
                        NroNomina = listContent[4],
                        Comentario = listContent[5],
                        Edad = Convert.ToInt32(listContent[6]),
                        RFC = listContent[7],
                        CodParentesco = Convert.ToInt32(listContent[8]),
                        Clave = Convert.ToInt32(listContent[9]),
                        Estado = listContent[10],
                        Colonia = listContent[11],
                        Ciudad = listContent[12],
                        Calle = listContent[13],
                        Numero = listContent[14],
                        CodPostal = listContent[15],
                        Nombres = listContent[16],
                        EstadoCivil = listContent[17],
                        ApPaterno = listContent[18],
                        ApMaterno = listContent[19],
                        Nacionalidad = listContent[20],
                        Email = listContent[21],
                        TelCasa = listContent[22],
                        Sexo = listContent[23],
                        FNacimiento = listContent[24],
                        FInicioServicio = listContent[25],
                        FFinServicio = listContent[26],
                        Vip = listContent[27],
                        FAntiguedad = listContent[28],
                        Estatus = listContent[29],
                        NroPoliza = listContent[30],
                    });
                }
                _RepoApiSase.AddRangeSase(_ListDetalle);





            }
            catch (Exception ex)
            {
                this._Logger.LogError(ex);
                _Response.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.AddException(ex);
            }
            return _Response;
        }
        public FileFTPDTO GetFileNameSCYF(List<String> _ListFiles)
        {
            List<FileFTPDTO> _List = new List<FileFTPDTO>();
            FileFTPDTO _FileName = new FileFTPDTO();
            try
            {
                if (_ListFiles.Count > 0)
                {
                    foreach (var item in _ListFiles)
                    {
                        //string index = item.Replace(_FolderName + "/", "");
                        DateTime fecha;
                        string hora = string.Empty;
                        //if (index.Substring(0, 1).ToString() == "A")
                        //{
                        //    if (index.Contains("-"))
                        //    {
                        //string stringDate = DateTime.ParseExact(item.Substring(1, 13).Replace("-", "").Trim(), "yyyyMMddHHmm", null).ToString("yyyy/MM/dd HH:mm");  //fecha = DateTime.ParseExact(item.Replace("DENTEGRA/", "").Substring(1, 13).Replace("-", "").Trim(), "yyyy/MM/dd", null);
                        //fecha = Convert.ToDateTime(stringDate, System.Globalization.CultureInfo.GetCultureInfo("en-Us").DateTimeFormat);
                        ////hora = item.Replace(_FolderName + "/", "").Substring(10, 13).Replace("-", " ");
                        _List.Add(new FileFTPDTO()
                        {
                            Nombre = item,
                            //Fecha = fecha
                        });
                        //}
                        //}
                    }
                }
                else
                {
                    throw new Exception("Ocurrio un error");
                }
                _FileName = _List.OrderByDescending(x => x.Nombre).FirstOrDefault();
            }
            catch (Exception ex)
            {

                throw new Exception("Ocurrio un error al obtener el archivo " + ex.Message);
            }
            return _FileName;
        }
        public OperationResult DownloadFile(string _NameFile, string _UserFtp, string _PasswordFtp)
        {
            OperationResult _Response = new OperationResult();
            try
            {

                FtpWebRequest _Request = (FtpWebRequest)WebRequest.Create("ftp://casedbsql.cloudapp.net/" + _NameFile);
                _Request.Method = WebRequestMethods.Ftp.DownloadFile;
                _Request.Credentials = new NetworkCredential(_UserFtp, _PasswordFtp);
                FtpWebResponse _Result = (FtpWebResponse)_Request.GetResponse();
                Stream responseStream = _Result.GetResponseStream();
                byte[] bytes;
                StreamReader reader = new StreamReader(responseStream);
                using (Stream fileStream = File.Create(@"C:\TempSCYF" + "\\" + _NameFile))
                {
                    responseStream.CopyTo(fileStream);
                }
                reader.Close();
                _Result.Close();


            }
            catch (Exception ex)
            {
                this._Logger.LogError(ex);
                _Response.SetStatusCode(OperationResult.StatusCodesEnum.INTERNAL_SERVER_ERROR);
                _Response.AddException(ex);
            }
            return _Response;
        }

    }
}
