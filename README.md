# EFCoreExample
A sample project for using EFCore ORM

1. Add a connection string in appsettings.json file.
2. Add dependency in Startup.cs file whenever you create a new Context :  
            services.AddEntityFrameworkSqlServer()
           .AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(Configuration["Connectionstring"]));
            
3. Add dependency injection to all the Interfaces and their implementation classes as follows :
      services.AddScoped<IEmployeeService, EmployeeService>();
