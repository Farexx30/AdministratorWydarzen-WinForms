namespace AdministratorWydarzen_WinForms
{
    partial class EventView
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
            components = new System.ComponentModel.Container();
            CreateEventGroupBox = new GroupBox();
            AddEventButton = new Button();
            PriorityComboBox = new ComboBox();
            PriorityLabel = new Label();
            TypeLabel = new Label();
            TypeComboBox = new ComboBox();
            EventDateLabel = new Label();
            EventDateDateTimePicker = new DateTimePicker();
            DescriptionTextBox = new TextBox();
            DescriptionLabel = new Label();
            TitleLabel = new Label();
            TitleTextBox = new TextBox();
            DeleteEventButton = new Button();
            AllEventsListBox = new ListBox();
            AllEventsGroupBox = new GroupBox();
            FilterByDateCheckBox = new CheckBox();
            SortDirectionLabel = new Label();
            SortDirectionComboBox = new ComboBox();
            SortByLabel = new Label();
            FilterByPriorityLabel = new Label();
            FilterByTypeLabel = new Label();
            FilterByDataLabel = new Label();
            FilterByDateDateTimePicker = new DateTimePicker();
            FilterByPriorityComboBox = new ComboBox();
            SortLabel = new Label();
            FilteryByLabel = new Label();
            SortByComboxBox = new ComboBox();
            FilterByTypeComboBox = new ComboBox();
            EventDetailsGroupBox = new GroupBox();
            EventDetailsTextBox = new TextBox();
            EventCreatorErrorProvider = new ErrorProvider(components);
            FilterByDateToolTip = new ToolTip(components);
            CreateEventGroupBox.SuspendLayout();
            AllEventsGroupBox.SuspendLayout();
            EventDetailsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EventCreatorErrorProvider).BeginInit();
            Load += MainEventViewOnLoad;
            FormClosed += MainEventViewOnClosed;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            SuspendLayout();
            // 
            // CreateEventGroupBox
            // 
            CreateEventGroupBox.Controls.Add(AddEventButton);
            CreateEventGroupBox.Controls.Add(PriorityComboBox);
            CreateEventGroupBox.Controls.Add(PriorityLabel);
            CreateEventGroupBox.Controls.Add(TypeLabel);
            CreateEventGroupBox.Controls.Add(TypeComboBox);
            CreateEventGroupBox.Controls.Add(EventDateLabel);
            CreateEventGroupBox.Controls.Add(EventDateDateTimePicker);
            CreateEventGroupBox.Controls.Add(DescriptionTextBox);
            CreateEventGroupBox.Controls.Add(DescriptionLabel);
            CreateEventGroupBox.Controls.Add(TitleLabel);
            CreateEventGroupBox.Controls.Add(TitleTextBox);
            CreateEventGroupBox.Location = new Point(3, 12);
            CreateEventGroupBox.Name = "CreateEventGroupBox";
            CreateEventGroupBox.Size = new Size(293, 403);
            CreateEventGroupBox.TabIndex = 0;
            CreateEventGroupBox.TabStop = false;
            CreateEventGroupBox.Text = "Informacje o wydarzeniu";
            // 
            // AddEventButton
            // 
            AddEventButton.Location = new Point(104, 349);
            AddEventButton.Name = "AddEventButton";
            AddEventButton.Size = new Size(86, 22);
            AddEventButton.TabIndex = 11;
            AddEventButton.Text = "Dodaj";
            AddEventButton.UseVisualStyleBackColor = true;
            AddEventButton.Click += AddEventButtonClick;
            // 
            // PriorityComboBox
            // 
            PriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            PriorityComboBox.FormattingEnabled = true;
            PriorityComboBox.Items.AddRange(new object[] { "Niski", "Średni", "Wysoki" });
            PriorityComboBox.Location = new Point(84, 294);
            PriorityComboBox.Name = "PriorityComboBox";
            PriorityComboBox.Size = new Size(154, 23);
            PriorityComboBox.TabIndex = 10;
            PriorityComboBox.SelectedIndex = 0;
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Location = new Point(6, 294);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(55, 15);
            PriorityLabel.TabIndex = 9;
            PriorityLabel.Text = "Priorytet:";
            // 
            // TypeLabel
            // 
            TypeLabel.AutoSize = true;
            TypeLabel.Location = new Point(6, 246);
            TypeLabel.Name = "TypeLabel";
            TypeLabel.Size = new Size(28, 15);
            TypeLabel.TabIndex = 8;
            TypeLabel.Text = "Typ:";
            // 
            // TypeComboBox
            // 
            TypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Items.AddRange(new object[] { "Praca", "Rodzina", "Rozrywka", "Sport", "Zdrowie" });
            TypeComboBox.Location = new Point(84, 246);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(154, 23);
            TypeComboBox.TabIndex = 7;
            TypeComboBox.SelectedIndex = 0;
            // 
            // EventDateLabel
            // 
            EventDateLabel.AutoSize = true;
            EventDateLabel.Location = new Point(6, 200);
            EventDateLabel.Name = "EventDateLabel";
            EventDateLabel.Size = new Size(72, 30);
            EventDateLabel.TabIndex = 6;
            EventDateLabel.Text = "Data\nrozpoczęcia:";
            // 
            // EventDateDateTimePicker
            // 
            EventDateDateTimePicker.CalendarFont = new Font("Segoe UI", 9F);
            EventDateDateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            EventDateDateTimePicker.MinDate = DateTime.Now;
            EventDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            EventDateDateTimePicker.Location = new Point(84, 200);
            EventDateDateTimePicker.Name = "EventDateDateTimePicker";
            EventDateDateTimePicker.Size = new Size(154, 23);
            EventDateDateTimePicker.TabIndex = 5;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(84, 79);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.MaxLength = 150;
            DescriptionTextBox.Size = new Size(189, 100);
            DescriptionTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 79);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(34, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Opis:";
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Location = new Point(6, 34);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(35, 15);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Tytuł:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(84, 34);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.MaxLength = 48;
            TitleTextBox.Size = new Size(154, 23);
            TitleTextBox.TabIndex = 0;
            // 
            // DeleteEventButton
            // 
            DeleteEventButton.Location = new Point(312, 416);
            DeleteEventButton.Name = "DeleteEventButton";
            DeleteEventButton.Size = new Size(86, 22);
            DeleteEventButton.TabIndex = 12;
            DeleteEventButton.Text = "Usuń";
            DeleteEventButton.UseVisualStyleBackColor = true;
            DeleteEventButton.Click += DeleteEventButtonClick;
            // 
            // AllEventsListBox
            // 
            AllEventsListBox.Font = new Font("Segoe UI", 15F);
            AllEventsListBox.FormattingEnabled = true;
            AllEventsListBox.ItemHeight = 28;
            AllEventsListBox.Location = new Point(0, 74);
            AllEventsListBox.Name = "AllEventsListBox";
            AllEventsListBox.Size = new Size(488, 200);
            AllEventsListBox.TabIndex = 13;
            AllEventsListBox.HorizontalScrollbar = true;
            AllEventsListBox.DrawMode = DrawMode.OwnerDrawFixed;
            AllEventsListBox.DrawItem += AllEventsListBoxDrawItems;
            AllEventsListBox.Click += AllEventsListBoxClick;
            // 
            // AllEventsGroupBox
            // 
            AllEventsGroupBox.Controls.Add(FilterByDateCheckBox);
            AllEventsGroupBox.Controls.Add(SortDirectionLabel);
            AllEventsGroupBox.Controls.Add(SortDirectionComboBox);
            AllEventsGroupBox.Controls.Add(SortByLabel);
            AllEventsGroupBox.Controls.Add(FilterByPriorityLabel);
            AllEventsGroupBox.Controls.Add(FilterByTypeLabel);
            AllEventsGroupBox.Controls.Add(FilterByDataLabel);
            AllEventsGroupBox.Controls.Add(FilterByDateDateTimePicker);
            AllEventsGroupBox.Controls.Add(FilterByPriorityComboBox);
            AllEventsGroupBox.Controls.Add(SortLabel);
            AllEventsGroupBox.Controls.Add(FilteryByLabel);
            AllEventsGroupBox.Controls.Add(SortByComboxBox);
            AllEventsGroupBox.Controls.Add(FilterByTypeComboBox);
            AllEventsGroupBox.Controls.Add(AllEventsListBox);
            AllEventsGroupBox.Location = new Point(302, 12);
            AllEventsGroupBox.Name = "AllEventsGroupBox";
            AllEventsGroupBox.Size = new Size(488, 274);
            AllEventsGroupBox.TabIndex = 13;
            AllEventsGroupBox.TabStop = false;
            AllEventsGroupBox.Text = "Wszystkie wydarzenia";
            // 
            // FilterByDateCheckBox
            // 
            FilterByDateCheckBox.AutoSize = true;
            FilterByDateCheckBox.Location = new Point(81, 30);
            FilterByDateCheckBox.Name = "FilterByDateCheckBox";
            FilterByDateCheckBox.Size = new Size(15, 14);
            FilterByDateCheckBox.TabIndex = 27;
            FilterByDateCheckBox.UseVisualStyleBackColor = true;
            FilterByDateCheckBox.MouseHover += FilterByDateCheckBoxMouseHover;
            FilterByDateCheckBox.CheckedChanged += FilterByDateCheckBoxCheckedChanged;
            // 
            // SortDirectionLabel
            // 
            SortDirectionLabel.AutoSize = true;
            SortDirectionLabel.Location = new Point(409, 30);
            SortDirectionLabel.Name = "SortDirectionLabel";
            SortDirectionLabel.Size = new Size(56, 15);
            SortDirectionLabel.TabIndex = 26;
            SortDirectionLabel.Text = "Kierunek:";
            // 
            // SortDirectionComboBox
            // 
            SortDirectionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortDirectionComboBox.Font = new Font("Segoe UI", 9F);
            SortDirectionComboBox.FormattingEnabled = true;
            SortDirectionComboBox.Items.AddRange(new object[] { "Rosnąco", "Malejąco" });
            SortDirectionComboBox.Location = new Point(409, 45);
            SortDirectionComboBox.Name = "SortDirectionComboBox";
            SortDirectionComboBox.Size = new Size(73, 23);
            SortDirectionComboBox.TabIndex = 25;
            SortDirectionComboBox.SelectedIndex = 0;
            SortDirectionComboBox.SelectedIndexChanged += SortDataChangedEvent;
            // 
            // SortByLabel
            // 
            SortByLabel.AutoSize = true;
            SortByLabel.Location = new Point(312, 30);
            SortByLabel.Name = "SortByLabel";
            SortByLabel.Size = new Size(58, 15);
            SortByLabel.TabIndex = 24;
            SortByLabel.Text = "Sortuj po:";
            // 
            // FilterByPriorityLabel
            // 
            FilterByPriorityLabel.AutoSize = true;
            FilterByPriorityLabel.Location = new Point(199, 30);
            FilterByPriorityLabel.Name = "FilterByPriorityLabel";
            FilterByPriorityLabel.Size = new Size(55, 15);
            FilterByPriorityLabel.TabIndex = 23;
            FilterByPriorityLabel.Text = "Priorytet:";
            // 
            // FilterByTypeLabel
            // 
            FilterByTypeLabel.AutoSize = true;
            FilterByTypeLabel.Location = new Point(102, 30);
            FilterByTypeLabel.Name = "FilterByTypeLabel";
            FilterByTypeLabel.Size = new Size(28, 15);
            FilterByTypeLabel.TabIndex = 22;
            FilterByTypeLabel.Text = "Typ:";
            // 
            // FilterByDataLabel
            // 
            FilterByDataLabel.AutoSize = true;
            FilterByDataLabel.Location = new Point(5, 30);
            FilterByDataLabel.Name = "FilterByDataLabel";
            FilterByDataLabel.Size = new Size(34, 15);
            FilterByDataLabel.TabIndex = 21;
            FilterByDataLabel.Text = "Data:";
            // 
            // FilterByDateDateTimePicker
            // 
            FilterByDateDateTimePicker.Enabled = false;
            FilterByDateDateTimePicker.CustomFormat = "dd.MM.yyyy";
            FilterByDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            FilterByDateDateTimePicker.Location = new Point(5, 45);
            FilterByDateDateTimePicker.Name = "FilterByDateDateTimePicker";
            FilterByDateDateTimePicker.Size = new Size(91, 23);
            FilterByDateDateTimePicker.TabIndex = 20;
            FilterByDateDateTimePicker.ValueChanged += FiltersChangedEvent;
            // 
            // FilterByPriorityComboBox
            // 
            FilterByPriorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByPriorityComboBox.FormattingEnabled = true;
            FilterByPriorityComboBox.Items.AddRange(new object[] { "Bez filtru", "Niski", "Średni", "Wysoki" });
            FilterByPriorityComboBox.Location = new Point(199, 45);
            FilterByPriorityComboBox.Name = "FilterByPriorityComboBox";
            FilterByPriorityComboBox.Size = new Size(91, 23);
            FilterByPriorityComboBox.TabIndex = 19;
            FilterByPriorityComboBox.SelectedIndex = 0;
            FilterByPriorityComboBox.SelectedIndexChanged += FiltersChangedEvent;
            // 
            // SortLabel
            // 
            SortLabel.AutoSize = true;
            SortLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SortLabel.Location = new Point(312, 15);
            SortLabel.Name = "SortLabel";
            SortLabel.Size = new Size(74, 15);
            SortLabel.TabIndex = 18;
            SortLabel.Text = "Sortowanie:";
            // 
            // FilteryByLabel
            // 
            FilteryByLabel.AutoSize = true;
            FilteryByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FilteryByLabel.Location = new Point(5, 15);
            FilteryByLabel.Name = "FilteryByLabel";
            FilteryByLabel.Size = new Size(38, 15);
            FilteryByLabel.TabIndex = 17;
            FilteryByLabel.Text = "Filtry:";
            // 
            // SortByComboxBox
            // 
            SortByComboxBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortByComboxBox.DropDownWidth = 95;
            SortByComboxBox.FormattingEnabled = true;
            SortByComboxBox.Items.AddRange(new object[] { "Data", "Typ", "Priorytet" });
            SortByComboxBox.Location = new Point(312, 45);
            SortByComboxBox.Name = "SortByComboxBox";
            SortByComboxBox.Size = new Size(91, 23);
            SortByComboxBox.TabIndex = 15;
            SortByComboxBox.SelectedIndex = 0;
            SortByComboxBox.SelectedIndexChanged += SortDataChangedEvent;
            // 
            // FilterByTypeComboBox
            // 
            FilterByTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            FilterByTypeComboBox.FormattingEnabled = true;
            FilterByTypeComboBox.Items.AddRange(new object[] { "Bez filtru", "Praca", "Rodzina", "Rozrywka", "Sport", "Zdrowie" });
            FilterByTypeComboBox.Location = new Point(102, 45);
            FilterByTypeComboBox.Name = "FilterByTypeComboBox";
            FilterByTypeComboBox.Size = new Size(91, 23);
            FilterByTypeComboBox.TabIndex = 14;
            FilterByTypeComboBox.SelectedIndex = 0;
            FilterByTypeComboBox.SelectedIndexChanged += FiltersChangedEvent;
            // 
            // EventDetailsGroupBox
            // 
            EventDetailsGroupBox.Controls.Add(EventDetailsTextBox);
            EventDetailsGroupBox.Location = new Point(302, 292);
            EventDetailsGroupBox.Name = "EventDetailsGroupBox";
            EventDetailsGroupBox.Size = new Size(488, 123);
            EventDetailsGroupBox.TabIndex = 14;
            EventDetailsGroupBox.TabStop = false;
            EventDetailsGroupBox.Text = "Szczegóły wydarzenia";
            // 
            // EventDetailsTextBox
            // 
            EventDetailsTextBox.Location = new Point(0, 22);
            EventDetailsTextBox.Name = "EventDetailsTextBox";
            EventDetailsTextBox.ReadOnly = true;
            EventDetailsTextBox.AutoSize = false;
            EventDetailsTextBox.Multiline = true;
            EventDetailsTextBox.ScrollBars = ScrollBars.Vertical;
            EventDetailsTextBox.Size = new Size(488, 100);
            EventDetailsTextBox.TabIndex = 0;
            // 
            // EventCreatorErrorProvider
            // 
            EventCreatorErrorProvider.ContainerControl = this;
            // 
            // EventView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EventDetailsGroupBox);
            Controls.Add(AllEventsGroupBox);
            Controls.Add(DeleteEventButton);
            Controls.Add(CreateEventGroupBox);
            Name = "EventView";
            Text = "Administator wydarzeń";
            CreateEventGroupBox.ResumeLayout(false);
            CreateEventGroupBox.PerformLayout();
            AllEventsGroupBox.ResumeLayout(false);
            AllEventsGroupBox.PerformLayout();
            EventDetailsGroupBox.ResumeLayout(false);
            EventDetailsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EventCreatorErrorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CreateEventGroupBox;
        private Label TitleLabel;
        private TextBox TitleTextBox;
        private Label DescriptionLabel;
        private TextBox DescriptionTextBox;
        private DateTimePicker EventDateDateTimePicker;
        private Label EventDateLabel;
        private ComboBox TypeComboBox;
        private ComboBox PriorityComboBox;
        private Label PriorityLabel;
        private Label TypeLabel;
        private Button AddEventButton;
        private Button DeleteEventButton;
        private ListBox AllEventsListBox;
        private GroupBox AllEventsGroupBox;
        private GroupBox EventDetailsGroupBox;
        private TextBox EventDetailsTextBox;
        private ComboBox SortByComboxBox;
        private ComboBox FilterByTypeComboBox;
        private Label FilteryByLabel;
        private Label SortLabel;
        private ErrorProvider EventCreatorErrorProvider;
        private DateTimePicker FilterByDateDateTimePicker;
        private ComboBox FilterByPriorityComboBox;
        private Label FilterByDataLabel;
        private Label FilterByPriorityLabel;
        private Label FilterByTypeLabel;
        private Label SortByLabel;
        private ComboBox SortDirectionComboBox;
        private Label SortDirectionLabel;
        private CheckBox FilterByDateCheckBox;
        private ToolTip FilterByDateToolTip;
    }
}
