using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BibleVerseApplication.Models
{
    [Bind(Include = "Id")]
    public class BibleUserEntry
    {

        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter your Bible Testament")]
        [Display(Name = "Testament Selection")]
        [DataType(DataType.Text)]
        [StringLength(50, MinimumLength = 12)]
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

    public enum BibleBookSelection
    {
        Genesis,
        Exodus,
        Leviticus,
        Numbers,
        Deuteronomy,
        Joshua,
        Judges,
        Ruth,
        Samuel,
        Kings,
        Chronicles, 
        Ezra,
        Nehemiah,
        Esther,
        Job,
        Psalms,
        Proverbs,
        Ecclesiastes,
        SongofSolomon,
        Isaiah,
        Jeremiah,
        Lamentations,
        Ezekiel,
        Daniel,
        Hosea,
        Joel,
        Amos,
        Obadiah,
        Jonah,
        Micah,
        Nahum,
        Habakkuk,
        Zephaniah,
        Haggai,
        Zechariah,
        Malachi,
        Matthew,
        Mark,
        Luke,
        John,     
        Romans,      
        Galatians,
        Ephesians,
        Philippians,
        Colossians,
        Titus
    }



}