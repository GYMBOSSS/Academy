using System.Net.Sockets;
using System.Text;

namespace restoranManager
{
    public partial class Form1 : Form
    {
        private string filePath_products = "data/products.txt";
        public Form1()
        {
            InitializeComponent();
            // products reader
            DirectoryInfo dir = new DirectoryInfo("data");
            if (!dir.Exists) dir.Create();
            if (!File.Exists(filePath_products)) File.Create(filePath_products).Close();

            list_products.Items.Clear();
            using (StreamReader sr = new StreamReader(filePath_products))
            {
                list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                list_products.Items.RemoveAt(list_products.Items.Count - 1);
            }

            foreach (string line in list_products.Items)
            {
                if (line.Length > 0)
                {
                    prod_load_name.Items.Add(line.Substring(line.IndexOf('-') + 2));
                    chProd_for_dish.Items.Add(line.Substring(line.IndexOf('-') + 2));
                }
            }
            // dishes reader
            DirectoryInfo dir_dishes = new DirectoryInfo("data/dishes");
            if (!dir_dishes.Exists) dir_dishes.Create();

            List<string> dishes_name = new List<string>();
            /*foreach (var i in dir_dishes.GetFiles())
            {
                dishes_name.Add(i.Name);
                using (StreamReader sr = new StreamReader($"data/dishes/{i.Name}.txt"))
                {

                    list_products.Items.AddRange(sr.ReadToEnd().Split("\r\n"));
                    list_products.Items.RemoveAt(list_products.Items.Count - 1);
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btn_prod_load_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (prod_load_name.Text == "")
            {
                flag = false;
                MessageBox.Show("напишите имя продукта");
            }
            if (flag)
            {

                using (StreamWriter sw = new StreamWriter(filePath_products))
                {
                    // исправить дублирование продуктов -
                    // добавление уже существующего продукта
                    // должно обновлять данные в списке и в файле
                    int t_i = -1;
                    string t_s = "";
                    foreach (var i in list_products.Items)
                    {
                        string temp = i.ToString();
                        temp = temp.Substring(temp.IndexOf('-') + 2);
                        if (temp == prod_load_name.Text)
                        {
                            t_i = list_products.Items.IndexOf(i);
                            t_s = i.ToString();
                            break;
                        }
                    }
                    if (t_i != -1)
                    {
                        list_products.Items[
                            list_products.Items.IndexOf(
                                t_s)] =
                                $"{prod_load_amount.Value} - {prod_load_name.Text}";
                    }
                    else
                    {
                        list_products.Items.Add(
                            $"{prod_load_amount.Value} - {prod_load_name.Text}");
                        chProd_for_dish.Items.Add($"{prod_load_name.Text}");
                    }

                    foreach (var item in list_products.Items)
                    {
                        sw.WriteLine($"{item}");
                    }
                }
            }
        }

        private void list_products_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_products.SelectedItem != null)
            {
                string selectNote = list_products.SelectedItem.ToString();
                prod_load_name.Text = selectNote.Substring(selectNote.IndexOf('-') + 2);
                prod_load_amount.Value = Int32.Parse(
                    selectNote.Substring(0, selectNote.IndexOf('-') - 1));
            }
        }

        private void list_dishes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listDish_item_Click(object sender, EventArgs e)
        {
            btn_dish_del.Visible = true;

            newDish_name.Text = ((Label)sender).Text;
            newDish_cost.Value = Int32.Parse(((Label)((Label)((Label)sender).Tag).Tag).Text);
            using (StreamReader sr = new StreamReader($"data/dishes/{((Label)sender).Text}.txt"))
            {
                string recept = sr.ReadToEnd();
                string[] products = recept.Split("\n");
            }
        }

        // dish list updater
        private void listDish_update(int amount, string dish_name, int cost)
        {


            if (table_listDishes.Controls.Find(dish_name,false).Count() > 0)
            {
/*
                ((Label)((Label)table_listDishes.
                    Controls.Find(dish_name, false)[0]).Tag).Text = amount.ToString();*/
            }
            else
            {
                Label d_name = new Label();
                d_name.Name = dish_name;
                d_name.Text = dish_name;
                d_name.Click += listDish_item_Click;

                Label d_amount = new Label();
                d_amount.Text = amount.ToString();
                d_name.Tag = d_amount;

                Label d_cost = new Label();
                d_cost.Text = cost.ToString();
                d_amount.Tag = d_cost;

                table_listDishes.Controls.Add(d_amount);
                table_listDishes.Controls.Add(d_name);
                table_listDishes.Controls.Add(d_cost);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = true;

            // здесь нужно описать проверки для записи блюда.
            // механика записи аналогична записи заметок (код в комментарии ниже из заметок).
            // нажатие на имя блюда откроет данное блюдо в редакторе рецепта (тот что справа)
            // точно так же, как и в заметках.
            // список продуктов так же необходимо модифицировать выводиться как таблицу

            if (flag)
            {
                string filePath = $"data/dishes/{newDish_name.Text}.txt";
                if (File.Exists(filePath)) { File.Delete(filePath); }
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                    {
                        sw.WriteLine(newDish_cost.Value);
                        foreach (var item in table_dish_prodList.Controls)
                        {
                            if (item is Label)
                            {
                                sw.Write(((Label)item).Text);
                            }
                            else
                            {
                                sw.WriteLine($":{((NumericUpDown)item).Value}");
                            }
                        }
                    }
                }
                listDish_update(1, newDish_name.Text, (int)newDish_cost.Value);
                table_dish_prodList.Controls.Clear();
                newDish_cost.Value = 2;
                newDish_name.Text = "";
            }
        }

        private void newDish_prodList_numUpDown_Del(object sender, EventArgs e)
        {
            if (((NumericUpDown)sender).Value == 0)
            {
                table_dish_prodList.Controls.Remove((Label)((NumericUpDown)sender).Tag);

                ((NumericUpDown)sender).Dispose();
            }
        }
        private void anonLabel(String text)
        {
            Label t = new Label();
            t.Text = text;
            table_dish_prodList.Controls.Add(t);

            NumericUpDown n = new NumericUpDown();
            n.Minimum = 0;
            n.Maximum = 100;
            n.Value = 1;
            n.Tag = t;
            n.BorderStyle = BorderStyle.None;
            n.ValueChanged += newDish_prodList_numUpDown_Del;
            table_dish_prodList.Controls.Add(n);
        }

        private void btn_addProd_to_newDish_Click(object sender, EventArgs e)
        {
            anonLabel(chProd_for_dish.Text);
            chProd_for_dish.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel_ListDishes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
