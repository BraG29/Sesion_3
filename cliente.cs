/*Nombre completo

Teléfono

Dirección

Email

Si es nuevo cliente*/


namespace cliente
{
    public struct Cliente
    {
        public string nombreCompleto { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public bool nuevoCliente { get; set; }

        public Cliente(string nombreCompleto, string telefono, string direccion, string email, bool nuevoCliente)
        {
            this.nombreCompleto = nombreCompleto;
            this.telefono = telefono;
            this.direccion = direccion;
            this.email = email;
            this.nuevoCliente = nuevoCliente;
        }

        public override string ToString() =>
            "-------------------------------------------------" +
            "\nDatos para el cliente " + nombreCompleto + ":" +
            "\nTeléfono: " + telefono +
            "\nDirección: " + direccion +
            "\nEmail: " + email + 
            "\nEs nuevo cliente?: " + ((nuevoCliente)? "Si" : "No") +
            "\n-------------------------------------------------";
    }
}
