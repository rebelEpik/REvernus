﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows;
using EVEStandard.Models;
using REvernus.Models;
using REvernus.ViewModels;

namespace REvernus.Views
{
    public partial class StructureSearchView : Window
    {
        public List<PlayerStructure> SelectedStructures { get; set; } = new List<PlayerStructure>();

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            if (DataContext is StructureSearchViewModel a) a.SelectPressed += CloseWindow;
        }

        private void CloseWindow(object sender, StructureSearchViewModel.StructureSearchEventArgs e)
        {
            SelectedStructures = e.SelectedStructures;

            Close();
        }

        public StructureSearchView()
        {
            InitializeComponent();
        }
    }
}
