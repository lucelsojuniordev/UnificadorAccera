using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace UnificadorAccera
{
    public partial class UnificadorAccera : Form
    {
        private string localMatriz { get; set; }
        private string localFilial { get; set; }
        private string localFinal { get; set; }

        public UnificadorAccera()
        {
            InitializeComponent();
            VerificaConfig();
        }

        private void Config() 
        {
            StreamWriter config = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.txt");
            config.Write("localMatriz#" + localMatriz + "\nlocalFilial#" + localFilial + "\nlocalFinal#" + localFinal);
            config.Close();
        }

        private void VerificaConfig() 
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.txt"))
            {
                try
                {
                    localMatriz = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.txt")[0].ToString().Split('#')[1];
                    localFilial = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.txt")[1].ToString().Split('#')[1];
                    localFinal = File.ReadAllLines(AppDomain.CurrentDomain.BaseDirectory.ToString() + "Config.txt")[2].ToString().Split('#')[1];
                    
                    lbLocalFinal.Text = localFinal;
                    lbLocalM.Text = localMatriz;
                    lbLocalF.Text = localFilial;
                }
                catch
                {
                    MessageBox.Show("Verifique os locais dos aquivos");
                    return;
                }
            }
        }

        private void btnBuscaM_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowDialog();
            localMatriz = dir.SelectedPath;
            lbLocalM.Text = dir.SelectedPath;
        }

        private void btnBuscaF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowDialog();
            localFilial = dir.SelectedPath;
            lbLocalF.Text = dir.SelectedPath;
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string arq_final = localFinal;
            DataSet data = new DataSet();
            
            if (string.IsNullOrEmpty(localMatriz) || string.IsNullOrEmpty(localFilial) || string.IsNullOrEmpty(localFinal)) 
            {
                MessageBox.Show("Verifique os locais dos aquivos");
                return;
            }
            Config();
            Gerardor gerardor = new Gerardor(localMatriz , localFilial, localFinal);
            gerardor.Gerar();

        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dir = new FolderBrowserDialog();
            dir.ShowDialog();
            localFinal = dir.SelectedPath;
            lbLocalFinal.Text = dir.SelectedPath;
        }
    }
}
