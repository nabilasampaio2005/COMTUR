﻿using COMTUR.Models.Enum;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace COMTUR.Models;

[Table("tipoatracao")]

public class TipoAtracaoModel
{

	[Key]
	[Column("tipoatracaoid")]
	public int Id { get; set; }
	[Column("nome")]
	public string Nome { get; set; }

	// relação com Atracao
	[JsonIgnore]
	public ICollection<AtracaoModel>? Atracao { get; set; }

	[JsonIgnore]
	public UsuarioModel? UsuarioModel { get; set; }

	[Column("usuarioid")]
	[ForeignKey("usuarioid")]
	public int IdUsuario { get; set; }

	[Column("statustipoatracao")]
	public TipoStatus Status { get; set; }

	public void Approved() => Status = StatusEnumExtensions.Approved();
	public void Inactive() => Status = StatusEnumExtensions.Inactive();
	public void Disapproved() => Status = StatusEnumExtensions.Disapproved();
	public void Analyzing() => Status = StatusEnumExtensions.Analyzing();

	public string GetState() => IStatusStateExtensions.GetState(this.Status);
	public bool CanInactive() => IStatusStateExtensions.CanInactive(this.Status);
	public bool CanAnalyzing() => IStatusStateExtensions.CanAnalyzing(this.Status);
	public bool CanApproved() => IStatusStateExtensions.CanApproved(this.Status);
	public bool CanDisapproved() => IStatusStateExtensions.CanDisapproved(this.Status);
}