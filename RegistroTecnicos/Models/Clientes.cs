﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroTecnicos.Models;

public class Clientes {
    [Key]
    public int ClientesId { get; set; }

    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "solo se permiten Letras")]
    [Required(ErrorMessage = "Campo Obligatorio")]

    public string? Nombres { get; set; }

   
    [Required(ErrorMessage = "Campo Obligatorio")]
    public DateTime? FechaIngreso { get; set; } = DateTime.Now;

    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "solo se permiten Letras")]
    [Required(ErrorMessage = "Campo Obligatorio")]
    public string? Direccion { get; set; }

    [StringLength(11, ErrorMessage = "El Rnc no debe tener mas de 11 numeros")]
    [RegularExpression(@"^[0-9]+$", ErrorMessage = "Solo se permiten numeros")]
    [Required(ErrorMessage = "Campo Obligatorio")]

    public string? Rnc { get; set; }

    [RegularExpression(@"^[0-9]+$", ErrorMessage = "Solo se permiten numeros")]
    [Required(ErrorMessage = "Campo Obligatorio")]
    public decimal? LimiteCredito { get; set; }

    //se inicia aqui con la relacion entre tablas 

    [Required(ErrorMessage = "Campo obligatorio")]
    [ForeignKey("TecnicosId")]

    public int TecnicosId { get; set; }


    ///aqui ponemos la instancia 
    public Tecnicos? Tecnicos { get; set; }

  
}   

