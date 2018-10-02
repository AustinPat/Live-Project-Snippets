 // Made two new properties to the ViewModel
 
 [DisplayName("Most Common Company Applied For")]
        public string CommonAppliedCompany { get; set; }
        [DisplayName("Common Application Catagory")]
        public JPJobCategory CommonAppCategory { get; set; }
        
  //added the properties to the constructor
        
       public AnalyticsViewModel(decimal JPAverageSalary, double JPAverageApps, JPJobCategory CommonJobCategory, string CommonCompany, int JPDaysOnJobPlacement, string CommonAppliedCompany, JPJobCategory CommonAppCategory)
      {
          this.JPAverageSalary = JPAverageSalary;
          this.JPAverageApps = JPAverageApps;
          this.CommonJobCategory = CommonJobCategory;
          this.CommonCompany = CommonCompany;
          this.CommonAppliedCompany = CommonAppliedCompany;
          this.CommonAppCategory = CommonAppCategory;
          this.JPDaysOnJobPlacement = JPDaysOnJobPlacement;
  
    // I then made the properties calculate the most frequently
applied to company, and the most applied to job category in the database.
  
   string commonAppliedCompany = averageAppsList.GroupBy(x => x.JPCompanyName) // calculates the most common company applied for
                .OrderByDescending(x => x.Count()).First().Key;

            JPJobCategory commonAppCategory = averageAppsList.GroupBy(x => x.JPJobCategory) // calculates the most common job category
                .OrderByDescending(x => x.Count()).First().Key;
