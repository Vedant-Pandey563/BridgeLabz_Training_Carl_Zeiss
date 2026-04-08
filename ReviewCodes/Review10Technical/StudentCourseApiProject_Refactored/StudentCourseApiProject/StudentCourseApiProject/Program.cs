using BusinessLayer.Interfaces;
using BusinessLayer.Services;
using DataBaseLayer.Interfaces;
using DataBaseLayer.Repositories;

var builder = WebApplication.CreateBuilder(args);

// register services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// conn string
var connectionString = builder.Configuration.GetConnectionString("StudentCourseDb")
    ?? throw new InvalidOperationException("Connection string 'StudentCourseDb' was not found.");

//register dependencies
builder.Services.AddScoped<IStudentRepository>(_ => new StudentRepository(connectionString));
builder.Services.AddScoped<ICourseRepository>(_ => new CourseRepository(connectionString));
builder.Services.AddScoped<IEnrollmentRepository>(_ => new EnrollmentRepository(connectionString));

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();

var app = builder.Build();

//middleware pipeline starts
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(); // adding swagger frontend parts
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
//final web app start
app.Run();
