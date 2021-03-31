var treeGridDataSource = [
           {
               "Name": "Windows",
               "DateModified": "06/26/2014",
               "Type": "File Folder",
               "DateCreated": "06/16/2014",
               "Children": [
                   {
                       "Name": "Users",
                       "DateModified": "06/26/2014",
                       "Type": "File Folder",
                       "DateCreated": "06/16/2014",
                       "Children": [
                           {
                               "Name": "Public",
                               "DateModified": "06/26/2014",
                               "Type": "File Folder",
                               "DateCreated": "06/16/2014",
                               "Children": [
                                   {
                                       "Name": "Documents ",
                                       "DateModified": "06/26/2014",
                                       "Type": "File Folder",
                                       "DateCreated": "06/16/2014",
                                       "Children": [
                                           { "Name": "Document 1", "DateModified": "06/26/2014", "Type": "HTML document", "DateCreated": "06/16/2014", },
                                           { "Name": "Document 2", "DateModified": "06/26/2014", "Type": "HTML document", "DateCreated": "06/16/2014", },
                                           { "Name": "Document 3", "DateModified": "06/26/2014", "Type": "HTML document", "DateCreated": "06/16/2014", }
                                       ]
                                   }
                               ]
                           }
                       ]
                   }
               ]
           }
];

var projectData = [
     {
         taskID: 1,
         taskName: "Planning",
         startDate: "02/03/2014",
         endDate: "02/07/2014",
         progress: 100,
         duration:5,
         subtasks: [
             { taskID: 2, taskName: "Plan timeline", startDate: "02/03/2014", endDate: "02/07/2014", duration: 5, progress: 100 },
             { taskID: 3, taskName: "Plan budget", startDate: "02/03/2014", endDate: "02/07/2014", duration: 5, progress: 100 },
             { taskID: 4, taskName: "Allocate resources", startDate: "02/03/2014", endDate: "02/07/2014", duration: 5, progress: 100 },
             { taskID: 5, taskName: "Planning complete", startDate: "02/07/2014", endDate: "02/07/2014", duration: 0, progress: 0 }
         ]
     },
     {
         taskID: 6,
         taskName: "Design",
         startDate: "02/10/2014",
         endDate: "02/14/2014",
         duration: 3,
         progress: 86,
         subtasks: [
             { taskID: 7, taskName: "Software Specification", startDate: "02/10/2014", endDate: "02/12/2014", duration: 3, progress: 60 },
             { taskID: 8, taskName: "Develop prototype", startDate: "02/10/2014", endDate: "02/12/2014", duration: 3, progress: 100 },
             { taskID: 9, taskName: "Get approval from customer", startDate: "02/13/2014", endDate: "02/14/2014", duration: 2, progress: 100 },
             { taskID: 10, taskName: "Design complete", startDate: "02/14/2014", endDate: "02/14/2014", duration: 0, progress: 0 }
         ]
     },
	 {
                taskID: 12,
                taskName: "Implementation Phase",
                startDate: "02/17/2014",
                endDate: "02/27/2014",
                subtasks: [
                    {
                        taskID: 13,
                        taskName: "Phase 1",
                        startDate: "02/17/2014",
                        endDate: "02/27/2014",
                        subtasks: [{
                            taskID: 14,
                            taskName: "Implementation Module 1",
                            startDate: "02/17/2014",
                            endDate: "02/27/2014",
                            subtasks: [
                                { taskID: 15, taskName: "Development Task 1", startDate: "02/17/2014", endDate: "02/19/2014", duration: 3, progress: "50" },
                                { taskID: 16, taskName: "Development Task 2", startDate: "02/17/2014", endDate: "02/19/2014", duration: 3, progress: "50" },
                                { taskID: 17, taskName: "Testing", startDate: "02/20/2014", endDate: "02/21/2014", duration: 2, progress: "0" },
                                { taskID: 18, taskName: "Bug fix", startDate: "02/24/2014", endDate: "02/25/2014", duration: 2, progress: "0" },
                                { taskID: 19, taskName: "Customer review meeting", startDate: "02/26/2014", endDate: "02/27/2014", duration: 2, progress: "0" },
                                { taskID: 20, taskName: "Phase 1 complete", startDate: "02/27/2014", endDate: "02/27/2014", duration: 0}
                                
                            ]
                        }]
                    },
                    
                    {
                        taskID: 21,
                        taskName: "Phase 2",
                        startDate: "02/17/2014",
                        endDate: "02/28/2014",
                        subtasks: [{
                            taskID: 22,
                            taskName: "Implementation Module 2",
                            startDate: "02/17/2014",
                            endDate: "02/28/2014",
                            subtasks: [
                                { taskID: 23, taskName: "Development Task 1", startDate: "02/17/2014", endDate: "02/20/2014", duration: 4, progress: "50",  },
                                { taskID: 24, taskName: "Development Task 2", startDate: "02/17/2014", endDate: "02/20/2014", duration: 4, progress: "50", },
                                { taskID: 25, taskName: "Testing", startDate: "02/21/2014", endDate: "02/24/2014", duration: 2, progress: "0", },
                                { taskID: 26, taskName: "Bug fix", startDate: "02/25/2014", endDate: "02/26/2014", duration: 2, progress: "0",  },
                                { taskID: 27, taskName: "Customer review meeting", startDate: "02/27/2014", endDate: "02/28/2014", duration: 2, progress: "0" },
                                { taskID: 28, taskName: "Phase 2 complete", startDate: "02/28/2014", endDate: "02/28/2014", duration: 0 }

                            ]
                        }]
                    },
                    
                    {
                        taskID: 29,
                        taskName: "Phase 3",
                        startDate: "02/17/2014",
                        endDate: "02/27/2014",
                        subtasks: [{
                            taskID: 30,
                            taskName: "Implementation Module 3",
                            startDate: "02/17/2014",
                            endDate: "02/27/2014",
                            subtasks: [
                                { taskID: 31, taskName: "Development Task 1", startDate: "02/17/2014", endDate: "02/19/2014", duration: 3, progress: "50" },
                                { taskID: 32, taskName: "Development Task 2", startDate: "02/17/2014", endDate: "02/19/2014", duration: 3, progress: "50" },
                                { taskID: 33, taskName: "Testing", startDate: "02/20/2014", endDate: "02/21/2014", duration: 2, progress: "0"},
                                { taskID: 34, taskName: "Bug fix", startDate: "02/24/2014", endDate: "02/25/2014", duration: 2, progress: "0"},
                                { taskID: 35, taskName: "Customer review meeting", startDate: "02/26/2014", endDate: "02/27/2014", duration: 2, progress: "0"},
                                { taskID: 36, taskName: "Phase 3 complete", startDate: "02/27/2014", endDate: "02/27/2014", duration: 0},

                            ]
                        }]
                    }
                ]
            }
];

var templateData=[{
            "Name": "Robert King",
            "FullName": "Robert King",
            "Designation": "Chief Executive Officer",
            "EmployeeID": "EMP001",
            "Address": "507 - 20th Ave. E.Apt. 2A, Seattle",
            "Contact": "(206) 555-9857",
            "Country": "USA",
            "DOB": "2/15/1963",

            "Children": [{
                "Name": "David william",
                "FullName": "David william",
                "Designation": "Vice President",
                "EmployeeID": "EMP004",
                "Address": "722 Moss Bay Blvd., Kirkland",
                "Country": "USA",
                "Contact": "(206) 555-3412",
                "DOB": "5/20/1971",


                "Children": [{
                    "Name": "Nancy Davolio",
                    "FullName": "Nancy Davolio",
                    "Designation": "Marketing Executive",
                    "EmployeeID": "EMP035",
                    "Address": "4110 Old Redmond Rd., Redmond",
                    "Country": "USA",
                    "Contact": "(206) 555-8122",
                    "DOB": "3/19/1966",
                    "Children": [
                        {
                            "Name": "Andrew Fuller",
                            "FullName": "Andrew Fuller",
                            "Designation": "Sales Representative",
                            "EmployeeID": "EMP045",
                            "Address": "14 Garrett Hill, London",
                            "Country": "UK",
                            "Contact": "(71) 555-4848",
                            "DOB": "9/20/1980"
                        },
                    {
                        "Name": "Anne Dodsworth",
                        "FullName": "Anne Dodsworth",
                        "Designation": "Sales Representative",
                        "EmployeeID": "EMP091",
                        "Address": "4726 - 11th Ave. N.E., Seattle",
                        "Country": "USA",
                        "Contact": "(206) 555-1189",
                        "DOB": "10/19/1989"
                    },
                    {
                        "Name": "Michael Suyama",
                        "FullName": "Michael Suyama",
                        "Designation": "Sales Representative",
                        "EmployeeID": "EMP110",
                        "Address": "Coventry House Miner Rd., London",
                        "Country": "UK",
                        "Contact": "(71) 555-3636",
                        "DOB": "11/02/1987"
                    },
                    {
                        "Name": "Janet Leverling",
                        "FullName": "Janet Leverling",
                        "Designation": "Sales Coordinator",
                        "EmployeeID": "EMP131",
                        "Address": "Edgeham Hollow Winchester Way, London",
                        "Country": "UK",
                        "Contact": "(71) 555-3636",
                        "DOB": "11/06/1990"
                    },
                    ]

                },
                {
                    "Name": "Romey Wilson",
                    "FullName": "Romey Wilson",
                    "Designation": "Sales Executive",
                    "EmployeeID": "EMP039",
                    "Address": "7 Houndstooth Rd., London",
                    "Country": "UK",
                    "Contact": "(71) 555-3690",
                    "DOB": "02/02/1980",
                    "Children": [
                    {
                        "Name": "Margaret Peacock",
                        "FullName": "Margaret Peacock",
                        "Designation": "Sales Representative",
                        "EmployeeID": "EMP213",
                        "Address": "4726 - 11th Ave. N.E., California",
                        "Country": "USA",
                        "Contact": "(206) 555-1989",
                        "DOB": "01/21/1986"
                    },
                    {
                        "Name": "Laura Callahan",
                        "FullName": "Laura Callahan",
                        "Designation": "Sales Coordinator",
                        "EmployeeID": "EMP201",
                        "Address": "Coventry House Miner Rd., London",
                        "Country": "UK",
                        "Contact": "(71) 555-2222",
                        "DOB": "12/01/1990"
                    },
                    {
                        "Name": "Steven Buchanan",
                        "FullName": "Steven Buchanan",
                        "Designation": "Sales Representative",
                        "EmployeeID": "EMP197",
                        "Address": "200 Lincoln Ave, Salinas, CA 93901",
                        "Country": "USA",
                        "Contact": "(831) 758-7408",
                        "DOB": "03/23/1987"
                    },
                    {
                        "Name": "Tedd Lawson",
                        "FullName": "Tedd Lawson",
                        "Designation": "Sales Representative",
                        "EmployeeID": "EMP167",
                        "Address": "200 Lincoln Ave, Salinas, CA 93901",
                        "Country": "USA",
                        "Contact": "(831) 758-7368 ",
                        "DOB": "08/09/1989"
                    },
                    ]
                }]
            }]
        }];