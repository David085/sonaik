using System;
using System.ComponentModel.DataAnnotations;

public class Qr
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int id { get; set; }

    [Column("Modelo", TypeName = "Varchar(50)")]
    public string Modelo { get; set; }

    [Column("Propietario", TypeName = "int")]
    public int propietario { get; set; }

    [Column("Descripcion", TypeName = "Varchar(150)")]
    public string Descripcion { get; set; }


}
