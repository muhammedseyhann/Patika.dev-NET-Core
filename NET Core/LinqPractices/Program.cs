using linq_practices.DbOperations;

namespace linq_practices
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataGenerator.Initialize();
            LİnqDbContext _context = new LİnqDbContext();
            var students = _context.Students.ToList<Student>();

            //Find() Primary key olarak işaretlenmiş veri üzerinden arama yapar
            Console.WriteLine("*** Find ***");
            var student = _context.Students.Where(student => student.StudentId == 1).FirstOrDefault();//Bulduğu ilk veriyi getiriyor.
            student = _context.Students.Find(2);
            Console.WriteLine(student.Name);

            //FirstOrDefault()
            Console.WriteLine();
            Console.WriteLine("*** Find ***");
            student = _context.Students.Where(student => student.Surname == "Arda").FirstOrDefault();
            Console.WriteLine(student.Name);

            student = _context.Students.FirstOrDefault(x => x.Surname == "Arda");
            Console.WriteLine(student);

            //SingleOrDefault
            Console.WriteLine();
            Console.WriteLine("*** SingleOrDefault ***");//Sorgulama sonunda kalan tek veriyi geri döndürür. Eğer listede birden fazla eleman varsa hata döndürür. Listede hiç eleman yoksa geriye null döndürür.
            student = _context.Students.SingleOrDefault(student => student.Name == "Deniz");
            Console.WriteLine(student.Surname);

            //ToList()
            Console.WriteLine();
            Console.WriteLine("*** ToList ***");
            var studentList = _context.Students.Where(student => student.ClassId == 2).ToList();
            Console.WriteLine(studentList.Count);

            //OrderBy
            Console.WriteLine();
            Console.WriteLine("*** OrderBy ***");
            students = _context.Students.OrderBy(x => x.StudentId).ToList();

            foreach (var sd in students)
            {
                Console.WriteLine(sd.StudentId + " - " + sd.Name + " - " + sd.Surname);

            }

            //OrderByDescending
            Console.WriteLine("*** OrderByDescending ***");
            students = _context.Students.OrderByDescending(x => x.StudentId).ToList();

            foreach (var sd in students)
            {
                Console.WriteLine(sd.StudentId + " - " + sd.Name + " - " + sd.Surname);

            }

            //Anonymous Object Result
            Console.WriteLine();
            Console.WriteLine("*** Anonymous Object Result ***");

            var anonymousObject = _context.Students
            .Where(x => x.ClassId == 2)
            .Select(x => new
            {
                Id = x.StudentId,
                FullName = x.Name + " " + x.Surname
            });

            foreach (var obj in anonymousObject)
            {
                Console.WriteLine(obj.Id + " - " + obj.FullName);
            }
        }
    }
}