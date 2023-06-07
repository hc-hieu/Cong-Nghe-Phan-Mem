﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pinsta.Models.Entities;

[Table("likes")]
public class Like
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int likeId { get; set; }
    
    public int userId { get; set; }
    [ForeignKey("userId")]
    public User user { get; set; }
    
    [ForeignKey("imageId")]
    public int imageId { get; set; }
    public Image image { get; set; }
    
    [DataType(DataType.DateTime)]
    public DateTime timeStamp { get; set; }
}