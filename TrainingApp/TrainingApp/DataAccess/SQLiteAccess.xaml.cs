using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SQLite;
using TrainingApp.Annotations;
using TrainingApp.Interfaces;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrainingApp.DataAccess
{
    //[Table("Recipes")]
    public class Recipe : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement/*, Column("RecipeId")*/]
        public int Id { get; set; }

        private string _name;

        [MaxLength(255)]
        public string Name { get => _name;
            set
            {
                if(_name == value) 
                    return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SQLiteAccess : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;

        public SQLiteAccess ()
		{
			InitializeComponent ();
		    _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
		}

	    protected override async void OnAppearing()
	    {
	        await _connection.CreateTableAsync<Recipe>();

            var recipes = await _connection.Table<Recipe>().ToListAsync();
            _recipes = new ObservableCollection<Recipe>(recipes);
	        recipesListView.ItemsSource = _recipes;

            base.OnAppearing();
	    }

	    async void OnAdd(object sender, System.EventArgs e)
	    {
            var recipe = new  Recipe{Name = "Recipe " + DateTime.Now.Ticks };
            _recipes.Add(recipe);
	        await _connection.InsertAsync(recipe);
        }

        async void OnUpdate(object sender, System.EventArgs e)
	    {
	        var recipe = _recipes[0];
	        recipe.Name += " UPDATED";

	        await _connection.UpdateAsync(recipe);
        }

	    async void OnDelete(object sender, System.EventArgs e)
	    {
	        var recipe = _recipes[0];

	        _recipes.Remove(recipe);
            await _connection.DeleteAsync(recipe);
	    }
    }
}