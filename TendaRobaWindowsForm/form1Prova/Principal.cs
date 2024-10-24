namespace form1Prova
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gh(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NouProducte nouProducteForm = new NouProducte();

            this.Hide();
            nouProducteForm.FormClosed += (s, args) => this.Show();
            nouProducteForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Afegir afegirProducteForm = new Afegir();

            this.Hide();
            afegirProducteForm.FormClosed += (s, args) => this.Show();
            afegirProducteForm.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cerca_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Eliminar eliminarProducteForm = new Eliminar();

            this.Hide();
            eliminarProducteForm.FormClosed += (s, args) => this.Show();
            eliminarProducteForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Detalls detallsProducteForm = new Detalls();

            this.Hide();
            detallsProducteForm.FormClosed += (s, args) => this.Show();
            detallsProducteForm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightYellow;

            button1.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 2;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = SystemColors.Control;
            button1.FlatAppearance.BorderSize = 1;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightYellow;

            button6.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            button6.FlatAppearance.BorderSize = 2;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            button6.FlatAppearance.BorderColor = SystemColors.Control;
            button6.FlatAppearance.BorderSize = 1;
        }

        private void groupBox4_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.LightGray;
        }

        private void groupBox4_MouseLeave(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.WhiteSmoke;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.LightGray;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.LightGray;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.LightGray;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            groupBox4.BackColor = Color.LightGray;
        }
    }
}
