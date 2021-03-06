﻿using Game.Models;
using Game.ViewModels;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DeleteMonsterPage : ContentPage
	{
	    // ReSharper disable once NotAccessedField.Local
	    private MonsterDetailViewModel _viewModel;

        public Monster Data { get; set; }

        public DeleteMonsterPage(MonsterDetailViewModel viewModel)
        {
            // Save off the item
            Data = viewModel.Data;
            viewModel.Title = "Delete " + viewModel.Title;

            InitializeComponent();

            // Set the data binding for the page
            BindingContext = _viewModel = viewModel;
        }

	    private async void Delete_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(this, "DeleteData", Data);

            // Remove Item Details Page manualy
            Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);

            await Navigation.PopAsync();
        }

	    private async void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}