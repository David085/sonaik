using System;
using System.ComponentModel.DataAnnotations;

public class Zapato
{
    [Key]
    public string id { get; set; }
    public string Descripcion { get; set; }	

	public string Modelo { get; set;}


}
