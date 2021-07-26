using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Contatos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ContatosModelDataContext dc = new ContatosModelDataContext();

        ObservableCollection<Contato> cliLista = new ObservableCollection<Contato>();

        Contato cont;

        public MainWindow()
        {
            InitializeComponent();

            foreach (var c in dc.Contatos)

            {

                cliLista.Add(c);

            }

            listBox1.ItemsSource = cliLista;

        }

        private void BtnNovo_Click(object sender, RoutedEventArgs e)
        {
            //Contato cont = new Contato() { ContatoNome = "Não identificado" };
            
            txtContatoId.Text = "";
            txtNome.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";

            txtNome.IsEnabled = true;
            txtCelular.IsEnabled = true;
            txtEmail.IsEnabled = true;
            btnCancelar.IsEnabled = true;
            btnSalvar.IsEnabled = true;
            btnNovo.IsEnabled = false;
            btnExcluir.IsEnabled = false;
            btnEditar.IsEnabled = false;
            txtNome.Focus();
        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (txtContatoId.Text == "")
            {
                Contato cont = new Contato() { ContatoNome = txtNome.Text, ContatoCelular = txtCelular.Text, ContatoEmail = txtEmail.Text };

                dc.Contatos.InsertOnSubmit(cont);

                cliLista.Add(cont);

                txtContatoId.Text = "";
                txtNome.Text = "";
                txtCelular.Text = "";
                txtEmail.Text = "";
            }
           
            dc.SubmitChanges();

            txtNome.IsEnabled = false;
            txtCelular.IsEnabled = false;
            txtEmail.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnSalvar.IsEnabled = false;
            btnNovo.IsEnabled = true;
            btnExcluir.IsEnabled = true;
            btnEditar.IsEnabled = true;

            //AtualizarList();
        }

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            //txtNome.Text = "";
            //txtCelular.Text = "";
            //txtEmail.Text = "";
            txtNome.IsEnabled = false;
            txtCelular.IsEnabled = false;
            txtEmail.IsEnabled = false;
            btnCancelar.IsEnabled = false;
            btnSalvar.IsEnabled = false;
            btnNovo.IsEnabled = true;
            btnExcluir.IsEnabled = true;
            btnEditar.IsEnabled = true;
            AtualizarList();
        }

        private void BtnEditar_Click(object sender, RoutedEventArgs e)
        {
            if (txtContatoId.Text != "")
            {
                txtNome.IsEnabled = true;
                txtCelular.IsEnabled = true;
                txtEmail.IsEnabled = true;
                btnCancelar.IsEnabled = true;
                btnSalvar.IsEnabled = true;
                btnNovo.IsEnabled = false;
                btnExcluir.IsEnabled = false;
                btnEditar.IsEnabled = false;
                txtNome.Focus();
            }
        }

        private void BtnExcluir_Click(object sender, RoutedEventArgs e)
        {
            if (txtContatoId.Text != "")
            {
                if (listBox1.SelectedItem != null)
                {
                    if (MessageBox.Show("Confirma a exclusão desse Contato ?", "Confirmação", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                    {
                        Contato cont = (Contato)listBox1.SelectedItem;

                        //cli.Contatos.Clear();

                        dc.Contatos.DeleteOnSubmit((Contato)listBox1.SelectedItem);

                        cliLista.Remove((Contato)listBox1.SelectedItem);

                        //AtualizarList();

                    }
                }
            }
        }

        public void AtualizarList()
        {
            try
            {
                //InitializeComponent();

                //listBox1.Items.Clear();
                cliLista.Clear();

                foreach (var c in dc.Contatos)

                {

                    cliLista.Add(c);

                }
                listBox1.ItemsSource = null;
                listBox1.ItemsSource = cliLista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
