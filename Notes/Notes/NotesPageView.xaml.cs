using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using Xamarin.Forms;
using Notes.Models;
using Notes.Service;

namespace Notes
{
    public partial class NotesPageView : ContentPage
    {
        public List<Note> AllNotes { get; set; }
        public NotesPageView()
        {
            InitializeComponent();
        }
       
        protected override void OnAppearing()
        {
            base.OnAppearing();
            AllNotes = new List<Note>(Notess.Get());
            collectionViewListHorizontal.ItemsSource = AllNotes.OrderBy(d => d.Text);
        }
    }
}