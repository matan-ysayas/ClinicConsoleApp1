using ClinicConsoleApp1;

List<Doctor> doctorsList = new List<Doctor>();


void addDoctor()
{
    Console.WriteLine("enter doctor first name");
    string newDoctorName = Console.ReadLine();
    Console.WriteLine("enter docrot last name");
    string newDoctorLastName = Console.ReadLine();
    Console.WriteLine("enter the doctor job");
    string newDoctorJob = Console.ReadLine();
    Console.WriteLine("enter number of patients");
    int newDoctorNumOfPatients = int.Parse(Console.ReadLine());
    Console.WriteLine("enter doctor B day");
    string newDoctorBDay = Console.ReadLine();

    Doctor doctorToAdd = new Doctor(newDoctorName, newDoctorLastName, newDoctorJob, newDoctorNumOfPatients, newDoctorBDay);
    doctorsList.Add(doctorToAdd);
  
    createDoctorFile(doctorToAdd);

    addToAllDoctorsFile(doctorsList);

}


void createDoctorFile(Doctor obj)
{
    FileStream fs = new FileStream($@"c:\test\{obj.firstName}.txt", FileMode.Append);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        writer.WriteLine($" first name:{obj.firstName} || last name:{obj.lastName} || job:{obj.job} || number of patients:{obj.numOfPatients} || B day:{obj.yearOfBirth}");
    }



}

void addToAllDoctorsFile( List<Doctor> doctorList)
{
    FileStream fs = new FileStream($@"c:\test\allDoctors.txt", FileMode.Create);
    using (StreamWriter writer = new StreamWriter(fs))
    {
        for(int i = 0; i < doctorList.Count; i++)
        {
            writer.WriteLine($"id:{i} first name:{doctorList[i].firstName} || last name:{doctorList[i].lastName} || job:{doctorList[i].job} || number of patients:{doctorList[i].numOfPatients} || B day:{doctorList[i].yearOfBirth} ,");

        }

    }


}


 




void ClinicApp()
{

    Console.WriteLine($"for add a doctor press 1 \n for get a doctor press2\n for add a Patient to a doctor press 3\n for get all the doctors press 4");

    int options = int.Parse(Console.ReadLine());

    switch (options)
    {
        case 1:
            addDoctor();
            ClinicApp();
            break;





    }

};

ClinicApp();