  // How it looks in the controller to calculate how many applications a user has sent, and how many more they need to send until 35
  
  ViewBag.TotalApplications = applications.Count();
  ViewBag.AppGoal = (applications.Count() < 35) ? (35 - applications.Count()) : 0;
  
  //this is what the view looks like to display it
  
  
<div>
    <h3>
        Total Applications Completed: @ViewBag.TotalApplications
    </h3>

    <h3>
        How Many To Reach 35 Applications: @ViewBag.AppGoal
    </h3>
</div>

  
