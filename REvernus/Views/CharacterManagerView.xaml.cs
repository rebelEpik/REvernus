﻿using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using REvernus.Core;
using REvernus.Models;

namespace REvernus.Views
{
    /// <summary>
    /// Interaction logic for CharacterManagerView.xaml
    /// </summary>
    public partial class CharacterManagerView : UserControl
    {
        public CharacterManagerView()
        {
            InitializeComponent();
        }

        private void CharacterListView_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            var result = VisualTreeHelper.HitTest(this, e.GetPosition(this));
            if (result.VisualHit.GetType() != typeof(ListBoxItem))
            {
                CharacterListView.UnselectAll();
            }
        }

        private void DeleteCharactersButton_OnClick(object sender, MouseButtonEventArgs e)
        {
            var deleteList = new List<REvernusCharacter>();
            foreach (REvernusCharacter selectedItem in CharacterListView.SelectedItems)
            {
                deleteList.Add(selectedItem);
            }
            CharacterManager.RemoveCharacters(deleteList);
        }
    }
}
