using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Usuario
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int id { get; set; }

    [Column("Nombre", TypeName = "Varchar(90)")]
    public string Nombre { get; set; }

    [Column("Cedula", TypeName = "int")]
    public int Cedula { get;}

}
