
namespace restoranManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_ListDishes = new Panel();
            table_listDishes = new TableLayoutPanel();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel_dish_prodList = new Panel();
            table_dish_prodList = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            newDish_name = new TextBox();
            newDish_cost = new NumericUpDown();
            list_products = new ListBox();
            btn_addProd_to_newDish = new Button();
            btn_loda_new_dish = new Button();
            btn_prod_load = new Button();
            prod_load_amount = new NumericUpDown();
            chProd_for_dish = new ComboBox();
            Label = new Label();
            Label3 = new Label();
            label2 = new Label();
            prod_load_name = new ComboBox();
            list_dishes = new ListBox();
            btn_dish_del = new Button();
            panel_ListDishes.SuspendLayout();
            panel_dish_prodList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)newDish_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).BeginInit();
            SuspendLayout();
            // 
            // panel_ListDishes
            // 
            panel_ListDishes.BackColor = SystemColors.ActiveCaption;
            panel_ListDishes.Controls.Add(table_listDishes);
            panel_ListDishes.Location = new Point(363, 436);
            panel_ListDishes.Name = "panel_ListDishes";
            panel_ListDishes.Size = new Size(312, 253);
            panel_ListDishes.TabIndex = 0;
            panel_ListDishes.Paint += panel_ListDishes_Paint;
            // 
            // table_listDishes
            // 
            table_listDishes.BackColor = SystemColors.ActiveBorder;
            table_listDishes.ColumnCount = 3;
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_listDishes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_listDishes.Dock = DockStyle.Top;
            table_listDishes.Location = new Point(0, 0);
            table_listDishes.Name = "table_listDishes";
            table_listDishes.RowCount = 2;
            table_listDishes.RowStyles.Add(new RowStyle(SizeType.Percent, 65.38461F));
            table_listDishes.RowStyles.Add(new RowStyle(SizeType.Percent, 34.6153831F));
            table_listDishes.Size = new Size(312, 44);
            table_listDishes.TabIndex = 20;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(363, 407);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(469, 407);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(575, 407);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 6;
            // 
            // panel_dish_prodList
            // 
            panel_dish_prodList.BackColor = SystemColors.ActiveCaption;
            panel_dish_prodList.Controls.Add(table_dish_prodList);
            panel_dish_prodList.Location = new Point(723, 436);
            panel_dish_prodList.Name = "panel_dish_prodList";
            panel_dish_prodList.Size = new Size(312, 215);
            panel_dish_prodList.TabIndex = 2;
            // 
            // table_dish_prodList
            // 
            table_dish_prodList.BackColor = SystemColors.ActiveBorder;
            table_dish_prodList.ColumnCount = 3;
            table_dish_prodList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_dish_prodList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            table_dish_prodList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            table_dish_prodList.Dock = DockStyle.Top;
            table_dish_prodList.Location = new Point(0, 0);
            table_dish_prodList.Name = "table_dish_prodList";
            table_dish_prodList.RowCount = 2;
            table_dish_prodList.RowStyles.Add(new RowStyle(SizeType.Percent, 65.38461F));
            table_dish_prodList.RowStyles.Add(new RowStyle(SizeType.Percent, 34.6153831F));
            table_dish_prodList.Size = new Size(312, 44);
            table_dish_prodList.TabIndex = 21;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSize = true;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // newDish_name
            // 
            newDish_name.Location = new Point(723, 352);
            newDish_name.Name = "newDish_name";
            newDish_name.Size = new Size(215, 23);
            newDish_name.TabIndex = 7;
            // 
            // newDish_cost
            // 
            newDish_cost.Location = new Point(944, 352);
            newDish_cost.Name = "newDish_cost";
            newDish_cost.Size = new Size(91, 23);
            newDish_cost.TabIndex = 8;
            // 
            // list_products
            // 
            list_products.FormattingEnabled = true;
            list_products.ItemHeight = 15;
            list_products.Location = new Point(12, 12);
            list_products.Name = "list_products";
            list_products.Size = new Size(316, 244);
            list_products.TabIndex = 9;
            // 
            // btn_addProd_to_newDish
            // 
            btn_addProd_to_newDish.Location = new Point(945, 378);
            btn_addProd_to_newDish.Name = "btn_addProd_to_newDish";
            btn_addProd_to_newDish.Size = new Size(90, 52);
            btn_addProd_to_newDish.TabIndex = 10;
            btn_addProd_to_newDish.Text = "Добавить";
            btn_addProd_to_newDish.UseVisualStyleBackColor = true;
            // 
            // btn_loda_new_dish
            // 
            btn_loda_new_dish.Location = new Point(723, 657);
            btn_loda_new_dish.Name = "btn_loda_new_dish";
            btn_loda_new_dish.Size = new Size(215, 32);
            btn_loda_new_dish.TabIndex = 11;
            btn_loda_new_dish.Text = "Запись данных о блюде";
            btn_loda_new_dish.UseVisualStyleBackColor = true;
            btn_loda_new_dish.Click += button2_Click;
            // 
            // btn_prod_load
            // 
            btn_prod_load.Location = new Point(258, 347);
            btn_prod_load.Name = "btn_prod_load";
            btn_prod_load.Size = new Size(91, 23);
            btn_prod_load.TabIndex = 12;
            btn_prod_load.Text = "button3";
            btn_prod_load.UseVisualStyleBackColor = true;
            // 
            // prod_load_amount
            // 
            prod_load_amount.Location = new Point(199, 347);
            prod_load_amount.Name = "prod_load_amount";
            prod_load_amount.Size = new Size(53, 23);
            prod_load_amount.TabIndex = 13;
            // 
            // chProd_for_dish
            // 
            chProd_for_dish.FormattingEnabled = true;
            chProd_for_dish.Items.AddRange(new object[] { "рис", "мука", "яйцо", "специи", "мясо" });
            chProd_for_dish.Location = new Point(723, 381);
            chProd_for_dish.Name = "chProd_for_dish";
            chProd_for_dish.Size = new Size(216, 23);
            chProd_for_dish.TabIndex = 14;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(33, 295);
            Label.Name = "Label";
            Label.Size = new Size(38, 15);
            Label.TabIndex = 15;
            Label.Text = "label1";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(363, 295);
            Label3.Name = "Label3";
            Label3.Size = new Size(38, 15);
            Label3.TabIndex = 16;
            Label3.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(723, 295);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 17;
            label2.Text = "label1";
            // 
            // prod_load_name
            // 
            prod_load_name.FormattingEnabled = true;
            prod_load_name.Location = new Point(33, 347);
            prod_load_name.Name = "prod_load_name";
            prod_load_name.Size = new Size(160, 23);
            prod_load_name.TabIndex = 18;
            // 
            // list_dishes
            // 
            list_dishes.FormattingEnabled = true;
            list_dishes.ItemHeight = 15;
            list_dishes.Location = new Point(334, 12);
            list_dishes.Name = "list_dishes";
            list_dishes.Size = new Size(316, 244);
            list_dishes.TabIndex = 19;
            // 
            // btn_dish_del
            // 
            btn_dish_del.Location = new Point(944, 657);
            btn_dish_del.Name = "btn_dish_del";
            btn_dish_del.Size = new Size(91, 32);
            btn_dish_del.TabIndex = 20;
            btn_dish_del.Text = "Delete";
            btn_dish_del.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 705);
            Controls.Add(btn_dish_del);
            Controls.Add(list_dishes);
            Controls.Add(prod_load_name);
            Controls.Add(label2);
            Controls.Add(Label3);
            Controls.Add(Label);
            Controls.Add(chProd_for_dish);
            Controls.Add(prod_load_amount);
            Controls.Add(btn_prod_load);
            Controls.Add(btn_loda_new_dish);
            Controls.Add(btn_addProd_to_newDish);
            Controls.Add(list_products);
            Controls.Add(newDish_cost);
            Controls.Add(newDish_name);
            Controls.Add(panel_dish_prodList);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(panel_ListDishes);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel_ListDishes.ResumeLayout(false);
            panel_dish_prodList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)newDish_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)prod_load_amount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel_ListDishes;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel_dish_prodList;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox newDish_name;
        private NumericUpDown newDish_cost;
        private ListBox list_products;
        private Button btn_addProd_to_newDish;
        private Button btn_loda_new_dish;
        private Button btn_prod_load;
        private NumericUpDown prod_load_amount;
        private ComboBox chProd_for_dish;
        private Label Label;
        private Label Label3;
        private Label label2;
        private ComboBox prod_load_name;
        private ListBox list_dishes;
        private TableLayoutPanel table_listDishes;
        private TableLayoutPanel table_dish_prodList;
        private Button btn_dish_del;
    }
}
