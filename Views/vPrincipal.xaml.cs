namespace jcevallos_T1A.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string cedula = txtCedula.Text;
        string nombres = txtNombres.Text;
        string apellidos = txtApellidos.Text;
        string correo = txtCorreo.Text;
        string confirmarCorreo = txtConfirmarCorreo.Text;

       
        if (!cedula.All(char.IsDigit))
        {
            DisplayAlert("Error", "La cédula debe contener solo números.", "OK");
            return;
        }

        if (!nombres.All(char.IsLetter) || !apellidos.All(char.IsLetter))
        {
            DisplayAlert("Error", "Los nombres y apellidos deben contener solo letras.", "OK");
            return;
        }

        if (correo != confirmarCorreo)
        {
            DisplayAlert("Error", "Los correos no coinciden.", "OK");
            return;
        }

        string carrera = pickerCarrera.SelectedItem?.ToString() ?? "No seleccionada";
        string fecha = dateNacimiento.Date.ToString("dd/MM/yyyy");

        // Guardar en archivo TXT
        string contenido = $"Cédula: {cedula}\nNombres: {nombres}\nApellidos: {apellidos}\nCorreo: {correo}" +
            $"\nFecha Nacimiento: {fecha}\nCarrera: {carrera}";
        string ruta = Path.Combine(FileSystem.AppDataDirectory, "inscripcion.txt");
        File.WriteAllText(ruta, contenido);

        DisplayAlert("Éxito", "Datos guardados correctamente.", "OK");
    }

}
