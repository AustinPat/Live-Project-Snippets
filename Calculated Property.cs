//property to calculate the time between last contact date and current date.

public int CalculateLastContactDate
        {
            get
            {
                int days = ((DateTime.Now - JPLatestContactDate).Days);
                return (days);
            }

        }
        
//I then added the property to the JPStudentRundown view model and updated the controller.

 public int CalculateLastContactDate { get; set; }


public JPStudentRundown(string name, string email, string loc, int daycount, string linkedin, string port, int totalApplications, int totalApplicationsThisWeek, int jpid, bool jpGraduated, int calculateLastContactDate, int checkListStatus)
{
    StudentName = name;
    StudentEmail = email;
    StudentLocation = loc;
    StudentDayCount = daycount;
    StudentLinkedIn = linkedin;
    StudentPortfolio = port;
    TotalApplications = totalApplications;
    TotalApplicationsThisWeek = totalApplicationsThisWeek;
    JPStudentId = jpid;
    JPGraduated = jpGraduated;
    CalculateLastContactDate = calculateLastContactDate;
    CheckListStatus = checkListStatus;
}

//created a variable called LatestContact that checks the JPLatestContacts table and the JPStudents table
to see if they both have the same ApplicationUserId.

 var LatestContact = db.JPLatestContacts.Where(a => a.ApplicationUserId == student.ApplicationUserId).FirstOrDefault();
 
  var studentRundown = new JPStudentRundown(student.JPName, student.JPEmail, student.JPStudentLocation.ToString(), student.DaysSinceStart, student.JPLinkedIn, student.JPPortfolio, applicationCount, thisWeekCount, id, student.JPGraduated, LatestContact.CalculateLastContactDate, checkListStatus);
            return studentRundown;
            
 //How I displayed it in the view using Razor syntax.
   <th>
      @Html.DisplayNameFor(model => model.CalculateLastContactDate)
  </th>
