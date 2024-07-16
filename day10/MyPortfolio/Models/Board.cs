﻿using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class Board
    {
        [Key]
        public int Id { get; set; } // PK
        
        [Required]
        [MaxLength(50)]
        public string Name { get; set; } // 작성자명

        [MaxLength(20)]
        public string UserId { get; set; } // 작성자 아이디

        [Required]
        [MaxLength(250)]
        public string Title { get; set; } // 게시글 제목

        public string Contents { get; set; } // 게시글 내용

        public string Hit { get; set; } // 게시글 읽은 횟수

        public DateTime RegDate { get; set; } = DateTime.Now; // 게시글 작성일자

        public DateTime ModeTime { get; set; } // 게시글 최종 수정일자
    }
}
