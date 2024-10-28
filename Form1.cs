using System;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.StyledXmlParser.Jsoup.Nodes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1() // Construtor
        {
            InitializeComponent(); // Inicializa os componentes do designer
        }

        private void btnGerarPDF_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string idade = txtIdade.Text;
            string habilidades = txtHabilidades.Text;
            string formacao = txtFormacao.Text;
            string endereco = txtEndereco.Text;
            string testePersonalidade = txtTestePersonalidade.Text;
            string softSkills = txtSoftSkills.Text;

            // Use o diretório de Documentos do usuário
            string caminhoPDF = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "curriculo.pdf");

            using (PdfWriter writer = new PdfWriter(caminhoPDF))
            {
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);

                document.Add(new Paragraph("Currículo"));
                document.Add(new Paragraph("Nome: " + nome));
                document.Add(new Paragraph("Idade: " + idade));
                document.Add(new Paragraph("Endereço: " + endereco));
                document.Add(new Paragraph("Habilidades: " + habilidades));
                document.Add(new Paragraph("Formação: " + formacao));
                document.Add(new Paragraph("Teste de Personalidade: " + testePersonalidade));
                document.Add(new Paragraph("Soft Skills: " + softSkills));

                document.Close();
            }

            MessageBox.Show("PDF gerado com sucesso em: " + caminhoPDF);
        }

        // Métodos para manipulação de eventos de entrada e saída em caixas de texto
        private void txtNome_Enter(object sender, EventArgs e) => lblNomePlaceholder.Visible = false;
        private void txtNome_Leave(object sender, EventArgs e) => lblNomePlaceholder.Visible = string.IsNullOrEmpty(txtNome.Text);

        private void txtIdade_Enter(object sender, EventArgs e) => lblIdadePlaceholder.Visible = false;
        private void txtIdade_Leave(object sender, EventArgs e) => lblIdadePlaceholder.Visible = string.IsNullOrEmpty(txtIdade.Text);

        private void txtHabilidades_Enter(object sender, EventArgs e) => lblHabilidadesPlaceholder.Visible = false;
        private void txtHabilidades_Leave(object sender, EventArgs e) => lblHabilidadesPlaceholder.Visible = string.IsNullOrEmpty(txtHabilidades.Text);

        private void txtFormacao_Enter(object sender, EventArgs e) => lblFormacaoPlaceholder.Visible = false;
        private void txtFormacao_Leave(object sender, EventArgs e) => lblFormacaoPlaceholder.Visible = string.IsNullOrEmpty(txtFormacao.Text);

        private void txtEndereco_Enter(object sender, EventArgs e) => lblEnderecoPlaceholder.Visible = false;
        private void txtEndereco_Leave(object sender, EventArgs e) => lblEnderecoPlaceholder.Visible = string.IsNullOrEmpty(txtEndereco.Text);

        private void txtTestePersonalidade_Enter(object sender, EventArgs e) => lblTestePersonalidadePlaceholder.Visible = false;
        private void txtTestePersonalidade_Leave(object sender, EventArgs e) => lblTestePersonalidadePlaceholder.Visible = string.IsNullOrEmpty(txtTestePersonalidade.Text);

        private void txtSoftSkills_Enter(object sender, EventArgs e) => lblSoftSkillsPlaceholder.Visible = false;
        private void txtSoftSkills_Leave(object sender, EventArgs e) => lblSoftSkillsPlaceholder.Visible = string.IsNullOrEmpty(txtSoftSkills.Text);
    }
}
