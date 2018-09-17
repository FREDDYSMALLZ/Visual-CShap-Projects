using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Web;
using System.Web.Mvc;

namespace TheBibleApplication.Models
{
    [Bind(Exclude = "Id")]
    public class BibleEntry
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter your Bible Testament")]
        [Display(Name = "Testament Selection")]
        [DataType(DataType.Text)]
        public string TestamentSelection { get; set; }

        [Required(ErrorMessage = "Please Enter your Book Selection")]
        [Display(Name = "Book Selection")]
        [DataType(DataType.Text)]
        [StringLength(1024)]
        public string BookSelection { get; set; }

        [Required(ErrorMessage = "Please Enter the Book Chapter Number")]
        [Display(Name = "Chapter Number")]
        [Range(1, 150, ErrorMessage = "The Chapter number must be between 1 and 150")]
        public int ChapterNumber { get; set; }

        [Required(ErrorMessage = "Please Enter the Verse Number from the book chapter")]
        [Display(Name = "Verse Number")]
        [Range(1, 150, ErrorMessage = "Verse must be between 1 and 150")]
        public int VerseNumber { get; set; }

        [Required(ErrorMessage = "Please Enter the Verse Text from the Book and Chapter Number")]
        [Display(Name = "Verse Text")]
        [DataType(DataType.MultilineText)]
        [StringLength(2000, MinimumLength = 4)]
        public string VerseText { get; set; }
    }
    public enum TestamentSelection{

        OldTestament,
        NewTestament

    }
}