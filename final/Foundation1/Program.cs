using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        // Video #1
        Video v1 = new Video();
        v1._author = "John Smith";
        v1._length = "300";
        v1._title = "Barbie Review";
        // Comments for Video 1
        v1._comments.Add(new Comment { _name = "Taylor Ross", _text = "Wow, Amazing Video!" });
        v1._comments.Add(new Comment { _name = "Jessica Laurance", _text = "Drop a tutorial?!" });
        v1._comments.Add(new Comment { _name = "Cece Best", _text = "Love This:)" });
        v1.DisplayVideos();

        // Video 2
        Video v2 = new Video();
        v2._author = "James Charles";
        v2._length = "1024";
        v2._title = "Make-Up Tutorial";
        // Comments for Video 2
        v2._comments.Add(new Comment { _name = "Albin Bartholomew", _text = "Your Make-Up looks so hip" });
        v2._comments.Add(new Comment { _name = "Esmond Giffard", _text = "I will be doing this for prom!!!" });
        v2._comments.Add(new Comment { _name = "Knox Ty", _text = "Lol you are so funny" });
        v2.DisplayVideos();

        // Video 3
        Video v3 = new Video();
        v3._author = "Beast Mode";
        v3._length = "1326";
        v3._title = "Making the largest pizza EVER";
        // Comments for Video 3
        v3._comments.Add(new Comment { _name = "Tonya Aster", _text = "I've actually seen a larger pizza before" });
        v3._comments.Add(new Comment { _name = "Clive Christabel", _text = "I would pay 5 dollars for a slice" });
        v3._comments.Add(new Comment { _name = "Jayceon Ash", _text = "I just wish you put extra cheese" });
        v3._comments.Add(new Comment { _name = "Rosanne Evangeline", _text = "AW you guys look like so much fun!" });
        v3.DisplayVideos();
        
    }
}