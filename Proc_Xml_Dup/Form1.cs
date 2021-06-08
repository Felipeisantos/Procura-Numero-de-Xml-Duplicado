using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Proc_Xml_Dup
{
    public partial class Form1 : Form
    {

        string Global_Patch;
        public Form1()
        {
            InitializeComponent();
            DateTime dt_now = DateTime.Now;
            Global_Patch = @"\\servidor\base\Nfe_Saidas\2021\" + dt_now.ToString("MM_yyy") + @"\XML";
        }


        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (Txt_Caminho.Text.Length > 0)
            {
                Find_Dup();
            }
            else
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.Description = "Procurar Pasta de Saidas";

                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                DateTime date = new DateTime();
                date = DateTime.Now;
                //fbd.SelectedPath = Global_Patch;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    Txt_Caminho.Text = fbd.SelectedPath;
                    Find_Dup();
                }
                else
                    MessageBox.Show("Selecione uma Pasta para Continuar", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Btn_Iniciar.Enabled = true;
        }
        public void Find_Dup()
        {
            Btn_Iniciar.Enabled = false;
            Lbl_1.Text = "Lista de Arquivos";
            Lbl_2.Text = "Lista de Duplicados";
            Txt_Arq.Text = null;
            Txt_Arq_dup.Text = null;
            DirectoryInfo dir = new DirectoryInfo(Txt_Caminho.Text);
            if (dir.Exists)
            {
                FileInfo[] Arquivos = dir.GetFiles("*.xml");
                List<FileInfo> Lista_Info = new List<FileInfo>();
                List<FileInfo> Lista_Info_Dups = new List<FileInfo>();

                foreach (FileInfo file in Arquivos)
                {
                    if (file.Name.Length > 27)
                    {
                        Txt_Arq.Text += file.Name + Environment.NewLine;
                        Lista_Info.Add(file);
                    }
                }

                foreach (FileInfo list in Lista_Info)
                {
                    int count = 0;
                    foreach (FileInfo list1 in Lista_Info)
                        if (list1.Name.Substring(22, 12) == list.Name.Substring(22, 12))
                            count++;
                    if (count >= 2)
                    {
                        Lista_Info_Dups.Add(list);

                        string X_Motivo = string.Empty;
                        try
                        {   //Lê o arquivo xml e pega a chave dele 
                            using (XmlReader reader = XmlReader.Create(list.FullName))
                            {
                                while (reader.Read())
                                {
                                    if (reader.IsStartElement())
                                    {
                                        switch (reader.Name.ToString())
                                        {
                                            case "xMotivo":
                                                X_Motivo = " - " + reader.ReadString();
                                                break;
                                        }
                                    }

                                }
                            }
                        }
                        catch (XmlException err)
                        {
                            MessageBox.Show("" + err.ToString() + "", "Erro");
                        }
                        if (X_Motivo == string.Empty)
                            Txt_Arq_dup.Text += list.Name + " - Sem Autorização" + Environment.NewLine;
                        else
                            Txt_Arq_dup.Text += list.Name + X_Motivo + Environment.NewLine;
                    }
                    count = 0;
                }
                Lbl_1.Text += "   " + Lista_Info.Count;
                Lbl_2.Text += "   " + Lista_Info_Dups.Count;
            }
            else
                MessageBox.Show("O diretorio Selecionado não existe");

        }
    }
}
