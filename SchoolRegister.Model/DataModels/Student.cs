
using System.Security.Cryptography.X509Certificates;
using SchoolRegister.Model.DataModels;

class Student:User {

    public Group Group {get;set;}
    public int? GroupId {get;set;}
    public IList<Grade> Grades {get;set;}
    public Parent Parent  {get;set;}
    public  int? ParentId {get;set;}

    public double AverageGrade => Grades == null || Grades.Count == 0 ? 0.0d : Math.Round(Grades.Average(g=>(int)g.GradeValue),1);

    public IDictionary<string,double>AverageGradePerSubject => Grades == null ? new Dictionary<string,double>():Grades.GroupBy(global=>global.Subject.Name)
            .Select(g=>new{SubjectName = g.Key,AvgGrade=Math.Round(g.Average(avg=>(int)avg.GradeValue),1)})
            .ToDictionary(avg => avg.SubjectName, avg =>avg.AvgGrade);
    public IDictionary<string,List<GradeScale>> GradesPerSubject=> Grades == null ? new Dictionary<string,List<GradeScale>>():Grades
        .GroupBy(g => g.Subject.Name)
        .Select(g=>new {SubjectName = g.Key, GradeList =g.Select(x=>x.GradeValue).ToList()})
        .ToDictionary(x=> x.SubjectName,x=>x.GradeList);

        public Student(){
            GroupId = 0;
            ParentId = 0;
            Group = new Group();
            Grades = new List<Grade>();
            Parent = new Parent ();
        }
}

