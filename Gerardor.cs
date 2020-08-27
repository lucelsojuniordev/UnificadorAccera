
using System;
using System.IO;
using System.Windows.Forms;

namespace UnificadorAccera
{
    public class Gerardor
    {
        private string pathM { get; set; }
        private string pathF { get; set; }
        private string pathFinal { get; set; }

        public Gerardor( string _pathM, string _pathF, string _pathFinal) 
        {
            this.pathM = _pathM;
            this.pathF = _pathF;
            this.pathFinal = _pathFinal;
        }

        public void Gerar()
        {
            DirectoryInfo dir = new DirectoryInfo(pathM);
            foreach (FileInfo arq in dir.GetFiles())
            {
                switch (arq.Name.Split('_')[1]) 
                {
                    case "SELLOUT":
                        GerarSELLOUT(arq.FullName);
                        break;
                    case "CADPROD":
                        GerarCADPROD(arq.FullName);
                        break;
                    case "POSESTQ":
                        GerarPOSESTQ(arq.FullName);
                        break;
                    case "PDVS":
                        GerarPDVS(arq.FullName);
                        break;
                    case "CADSITE":
                        GerarCADSITE(arq.FullName);
                        break;
                    default: 
                        break;
                }
                
            }

            foreach (FileInfo arq in dir.GetFiles())
            {
                arq.Delete();
            }

            DirectoryInfo dirF = new DirectoryInfo(pathF);
            foreach (FileInfo arq in dirF.GetFiles())
            {
                arq.Delete();
            }

            MessageBox.Show("Processo Concluído!!!");
            Application.Exit();           

        }

        private void GerarSELLOUT(string pathArquivoMatriz) 
        {
            DirectoryInfo dirF = new DirectoryInfo(pathF);
            string cab = string.Empty;
            string linhas = string.Empty;

            foreach (string linha in File.ReadAllLines(pathArquivoMatriz))
            {
                string[] a = linha.Split(';');
                if (a.Length == 4)
                {
                    cab += linha + "\n";
                }
                if (a.Length == 21)
                {
                    linhas += linha + "\n";
                }
            }

            foreach (FileInfo arq in dirF.GetFiles())
            {
                if ((arq.Name.Split('_').Length > 1) && (arq.Name.Split('_')[1] == "SELLOUT")) 
                {
                    foreach (string linha in File.ReadAllLines(arq.FullName))
                    {
                        string[] a = linha.Split(';');
                        if (a.Length == 21)
                        {
                            linhas += linha + "\n";
                        }
                    }
                }
            }

            StreamWriter cADSITE = new StreamWriter(pathFinal + "\\ACC_SELLOUT_" + Data() + ".txt");
            cADSITE.Write(cab + linhas + "E");
            cADSITE.Close();
        }

        private void GerarCADPROD(string pathArquivoMatriz)
        {
            string cab = string.Empty;
            string linhas = string.Empty;

            foreach (string linha in File.ReadAllLines(pathArquivoMatriz))
            {
                string[] a = linha.Split(';');
                if (a[0] == "H")
                {
                    cab += linha + "\n";
                }
                if (a[0] == "V")
                {
                    linhas += linha + "\n";
                }
            }

            StreamWriter cADSITE = new StreamWriter(pathFinal + "\\ACC_CADPROD_" + Data() + ".txt");
            cADSITE.Write(cab + linhas + "E");
            cADSITE.Close();
        }

        private void GerarPOSESTQ(string pathArquivoMatriz)
        {
            DirectoryInfo dirF = new DirectoryInfo(pathF);
            string cab = string.Empty;
            string linhas = string.Empty;

            foreach (string linha in File.ReadAllLines(pathArquivoMatriz))
            {
                string[] a = linha.Split(';');
                if (a.Length == 4)
                {
                    cab += linha + "\n";
                }
                if (a.Length == 9)
                {
                    linhas += linha + "\n";
                }
            }

            foreach (FileInfo arq in dirF.GetFiles())
            {
                if ((arq.Name.Split('_').Length > 1) && (arq.Name.Split('_')[1] == "POSESTQ"))
                {
                    foreach (string linha in File.ReadAllLines(arq.FullName))
                    {
                        string[] a = linha.Split(';');
                        if (a.Length == 9)
                        {
                            linhas += linha + "\n";
                        }
                    }
                }
            }

            StreamWriter cADSITE = new StreamWriter(pathFinal + "\\ACC_POSESTQ_" + Data() + ".txt");
            cADSITE.Write(cab + linhas + "E");
            cADSITE.Close();

        }
        private void GerarPDVS(string pathArquivoMatriz)
        {
            string cab = string.Empty;
            string linhas = string.Empty;

            foreach (string linha in File.ReadAllLines(pathArquivoMatriz))
            {
                string[] a = linha.Split(';');
                if (a[0] == "H")
                {
                    cab += linha + "\n";
                }
                if (a[0] == "V")
                {
                    linhas += linha + "\n";
                }
            }

            StreamWriter cADSITE = new StreamWriter(pathFinal + "\\ACC_PDVS_" + Data() + ".txt");
            cADSITE.Write(linhas + "E");
            cADSITE.Close();
        }
        private void GerarCADSITE(string pathArquivoMatriz)
        {
            DirectoryInfo dirF = new DirectoryInfo(pathF);
            string cab = string.Empty;
            string linhas = string.Empty;

            foreach (string linha in File.ReadAllLines(pathArquivoMatriz))
            {
                string[] a = linha.Split(';');
                if (a.Length == 3)
                {
                    cab += linha + "\n";
                }
                if (a.Length == 8)
                {
                    linhas += linha + "\n";
                }
            }

            foreach (FileInfo arq in dirF.GetFiles())
            {
                if ((arq.Name.Split('_').Length > 1) && (arq.Name.Split('_')[1] == "CADSITE"))
                {
                    foreach (string linha in File.ReadAllLines(arq.FullName))
                    {
                        string[] a = linha.Split(';');
                        if (a.Length == 8)
                        {
                            linhas += linha + "\n";
                        }
                    }

                }
            }
            
            StreamWriter cADSITE = new StreamWriter(pathFinal + "\\ACC_CADSITE_" + Data() + ".txt");
            cADSITE.Write(cab + linhas + "E");
            cADSITE.Close();
        }

        private string Data() 
        {
            string[] data = DateTime.Today.ToShortDateString().Split('/');
            return data[2].ToString() + data[1].ToString() + data[0].ToString();
        }
    }
}
