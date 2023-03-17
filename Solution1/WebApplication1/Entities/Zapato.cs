using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Zapato
{
    [Key]
    [Column("Id", TypeName = "int")]
    public int id { get; set; }

    [Column("Descripcion", TypeName = "varchar(150)")]
    public string Descripcion { get; set; }

    [Column("Modelo", TypeName = "String")]
    public string Modelo { get; set;}


}
