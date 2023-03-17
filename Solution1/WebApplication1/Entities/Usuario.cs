using System;
using System.ComponentModel.DataAnnotations;

public class Usuario
{
    [Key]
    public string id { get; set; }

    public string Nombre { get; set; }

	public int Cedula { get;}

}
