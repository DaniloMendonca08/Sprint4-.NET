﻿using System.ComponentModel.DataAnnotations;

namespace ApiAgroCare.DTOS.Avaliacoes
{
    public class AvaliacaoCriacaoDTO
    {
        [Range(1, 5, ErrorMessage = "A quantidade de estrelas deve ser entre 1 e 5.")]
        public int QtdEstrelas { get; set; }

        public string MsgAvaliacao { get; set; }

        public DateTime DataAvaliacao { get; set; } = DateTime.Now; // Data atual por padrão

        // Relacionamentos
        [Required(ErrorMessage = "O ID da consulta é obrigatório.")]
        public long ConsultaID { get; set; }

        [Required(ErrorMessage = "O ID do veterinário é obrigatório.")]
        public long VeterinarioID { get; set; }

        [Required(ErrorMessage = "O ID do usuário é obrigatório.")]
        public long UserID { get; set; }
    }
}