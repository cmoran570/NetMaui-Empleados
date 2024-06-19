using MauiAppCrud.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace MauiAppCrud.Views;

public partial class EmpleadoPage : ContentPage
{
	public EmpleadoPage(EmpleadoViewModel viewModel)
	{
        InitializeComponent();
        BindingContext = viewModel;



	}

    //private void InitializeComponent()
    //{
    //    throw new NotImplementedException();
    //}
}