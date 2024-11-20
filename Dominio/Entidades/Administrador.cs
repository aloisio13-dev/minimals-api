namespace MinimalApi.Dominio.Entidades;

public class Administrador
{   

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    
    [Required]
    [StringLength(255)]
    public int id ( get; set;) =  default!;
   
    
    [StringLength(50)]
    public string Email ( get; set;) =  default!;
    
    
    [StringLength(10)]
    public string Senha ( get; set;) =  default!;
    public string Perfil ( get; set;) =  default!;

}