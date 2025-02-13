using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace projekt_wronek
{
    public partial class Form1 : Form
    {
        private const string ClientConnectionString = "Data Source=clients.db";
        private const string ProductConnectionString = "Data Source=product.db";
        private const string OrderConnectionString = "Data Source=Orders.db";

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeCustomComponents();
            LoadClients();
            LoadProducts();
            LoadOrders();
        }
        private void InitializeCustomComponents()
        {
            ZamowieniaTextBox = new TextBox
            {
                Location = new System.Drawing.Point(628, 350),
                Size = new System.Drawing.Size(158, 20),
                ReadOnly = true
            };
            this.Controls.Add(ZamowieniaTextBox);
        }
        private void InitializeDatabase()
        {
            using (var clientConnection = new SqliteConnection(ClientConnectionString))
            {
                clientConnection.Open();
                var command = new SqliteCommand("CREATE TABLE IF NOT EXISTS Clients (Id INTEGER PRIMARY KEY AUTOINCREMENT, Nazwa TEXT)", clientConnection);
                command.ExecuteNonQuery();
            }

            using (var productConnection = new SqliteConnection(ProductConnectionString))
            {
                productConnection.Open();
                var command = new SqliteCommand("CREATE TABLE IF NOT EXISTS Products (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)", productConnection);
                command.ExecuteNonQuery();
            }
            using (var orderConnection = new SqliteConnection(OrderConnectionString))
            {
                orderConnection.Open();
                var command = new SqliteCommand("CREATE TABLE IF NOT EXISTS Orders (Id INTEGER PRIMARY KEY AUTOINCREMENT, Client TEXT, Product TEXT)", orderConnection);
                command.ExecuteNonQuery();
            }

        }

        private void LoadClients()
        {
            using (var connection = new SqliteConnection(ClientConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("SELECT Id, Nazwa FROM Clients", connection);

                using (var reader = command.ExecuteReader())
                {
                    ClientList.Items.Clear();
                    while (reader.Read())
                    {
                        var itemText = reader["Id"].ToString() + " " + reader["Nazwa"].ToString();
                        ClientList.Items.Add(itemText);
                    }
                }
            }
        }

        private void LoadProducts()
        {
            using (var connection = new SqliteConnection(ProductConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("SELECT Id, Name FROM Products", connection);

                using (var reader = command.ExecuteReader())
                {
                    ProduktListBox.Items.Clear();
                    while (reader.Read())
                    {
                        var itemText = reader["Id"].ToString() + " " + reader["Name"].ToString();
                        ProduktListBox.Items.Add(itemText);
                    }
                }
            }
        }
        private void LoadOrders()
        {
            using (var connection = new SqliteConnection(OrderConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("SELECT Id, Client, Product FROM Orders", connection);

                using (var reader = command.ExecuteReader())
                {
                    ZamowieniaListBox.Items.Clear();
                    while (reader.Read())
                    {
                        var itemText = reader["Id"].ToString() + " " + reader["Client"].ToString() + " - " + reader["Product"].ToString();
                        ZamowieniaListBox.Items.Add(itemText);
                    }
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadClients();
            LoadProducts();
            LoadOrders();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientList.SelectedItem != null)
            {
                string selectedItem = ClientList.SelectedItem.ToString();
                string name = selectedItem.Substring(selectedItem.IndexOf(' ') + 1);
                ClientTextBox.Text = name;
            }
        }

        private void ProduktListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProduktListBox.SelectedItem != null)
            {
                string selectedItem = ProduktListBox.SelectedItem.ToString();
                string name = selectedItem.Substring(selectedItem.IndexOf(' ') + 1);
                ProduktTextBox.Text = name;
            }
        }

        private void ClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClientAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ClientTextBox.Text))
            {
                using (var connection = new SqliteConnection(ClientConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("INSERT INTO Clients (Nazwa) VALUES (@nazwa)", connection);
                    command.Parameters.AddWithValue("@nazwa", ClientTextBox.Text);
                    command.ExecuteNonQuery();
                }
                LoadClients();
                ClientTextBox.Clear();
            }
            else
            {
                MessageBox.Show("WprowadŸ nazwê klienta.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProduktAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProduktTextBox.Text))
            {
                using (var connection = new SqliteConnection(ProductConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("INSERT INTO Products (Name) VALUES (@name)", connection);
                    command.Parameters.AddWithValue("@name", ProduktTextBox.Text);
                    command.ExecuteNonQuery();
                }
                LoadProducts();
                ProduktTextBox.Clear();
            }
            else
            {
                MessageBox.Show("WprowadŸ nazwê produktu.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProduktDel_Click(object sender, EventArgs e)
        {
            if (ProduktListBox.SelectedItem != null)
            {
                string selectedItem = ProduktListBox.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(' ')[0]);

                using (var connection = new SqliteConnection(ProductConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("DELETE FROM Products WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                LoadProducts();
                ProduktTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Wybierz produkt do usuniêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProduktEdit_Click(object sender, EventArgs e)
        {
            if (ProduktListBox.SelectedItem != null && !string.IsNullOrWhiteSpace(ProduktTextBox.Text))
            {
                string selectedItem = ProduktListBox.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(' ')[0]);

                using (var connection = new SqliteConnection(ProductConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("UPDATE Products SET Name = @name WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@name", ProduktTextBox.Text);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                LoadProducts();
                ProduktTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Wybierz produkt i wprowadŸ now¹ nazwê.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ProduktClear_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(ProductConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("DELETE FROM Products", connection);
                command.ExecuteNonQuery();


                command = new SqliteCommand("DELETE FROM sqlite_sequence WHERE name='Products'", connection);
                command.ExecuteNonQuery();
            }
            LoadProducts();
            ProduktTextBox.Clear();
        }

        private void ClientDel_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedItem != null)
            {
                string selectedItem = ClientList.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(' ')[0]);

                using (var connection = new SqliteConnection(ClientConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("DELETE FROM Clients WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                LoadClients();
            }
            else
            {
                MessageBox.Show("Wybierz klienta do usuniêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientEdit_Click(object sender, EventArgs e)
        {
            if (ClientList.SelectedItem != null && !string.IsNullOrWhiteSpace(ClientTextBox.Text))
            {
                string selectedItem = ClientList.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(' ')[0]);

                using (var connection = new SqliteConnection(ClientConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("UPDATE Clients SET Nazwa = @nazwa WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@nazwa", ClientTextBox.Text);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                LoadClients();
                ClientTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Wybierz klienta i wprowadŸ now¹ nazwê.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClientClear_Click(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection(ClientConnectionString))
            {
                connection.Open();
                var command = new SqliteCommand("DELETE FROM Clients", connection);
                command.ExecuteNonQuery();
            }
            LoadClients();
            ClientTextBox.Clear();
        }

        private void ProduktTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private TextBox ZamowieniaTextBox;
        private void ZamowieniaAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ClientTextBox.Text) && !string.IsNullOrWhiteSpace(ProduktTextBox.Text))
            {
                string client = ClientTextBox.Text;
                string product = ProduktTextBox.Text;

                using (var connection = new SqliteConnection(OrderConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("INSERT INTO Orders (Client, Product) VALUES (@client, @product)", connection);
                    command.Parameters.AddWithValue("@client", client);
                    command.Parameters.AddWithValue("@product", product);
                    command.ExecuteNonQuery();
                }
                LoadOrders();

                ClientTextBox.Clear();
                ProduktTextBox.Clear();
            }
            else
            {
                MessageBox.Show("WprowadŸ nazwê klienta i produktu.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ZamowieniaDel_Click(object sender, EventArgs e)
        {
            if (ZamowieniaListBox.SelectedItem != null)
            {
                string selectedItem = ZamowieniaListBox.SelectedItem.ToString();
                int id = int.Parse(selectedItem.Split(' ')[0]);

                using (var connection = new SqliteConnection(OrderConnectionString))
                {
                    connection.Open();
                    var command = new SqliteCommand("DELETE FROM Orders WHERE Id = @id", connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                LoadOrders();
            }
            else
            {
                MessageBox.Show("Wybierz zamówienie do usuniêcia.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ZamowieniaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ZamowieniaListBox.SelectedItem != null)
            {
                string selectedItem = ZamowieniaListBox.SelectedItem.ToString();
                if (int.TryParse(selectedItem.Split(' ')[0], out int id))
                {
                    using (var connection = new SqliteConnection(OrderConnectionString))
                    {
                        connection.Open();
                        var command = new SqliteCommand("SELECT Client, Product FROM Orders WHERE Id = @id", connection);
                        command.Parameters.AddWithValue("@id", id);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string client = reader["Client"].ToString();
                                string product = reader["Product"].ToString();
                                ZamowieniaTextBox.Text = $"Client: {client}, Product: {product}";
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("B³¹d formatu ID.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

