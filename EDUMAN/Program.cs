using EDUMAN.Data;
using EDUMAN.Repository;
using EDUMAN.Repository.Implements;
using EDUMAN.Services;
using EDUMAN.Services.Implements;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();

builder.Services.AddTransient<IClassService, ClassService>();
builder.Services.AddTransient<IClassRepository, ClassRepository>();

builder.Services.AddTransient<IDisciplineService, DisciplineService>();
builder.Services.AddTransient<IDisciplineRepository, DisciplineRepository>();

builder.Services.AddTransient<IEduTypeService, EduTypeService>();
builder.Services.AddTransient<IEducationTypeRepository, EducationTypeRepository>();

builder.Services.AddTransient<IMajorService, MajorService>();
builder.Services.AddTransient<IMajorRepository, MajorRepository>();

builder.Services.AddTransient<IRewardService, RewardService>();
builder.Services.AddTransient<IRewardRepository, RewardRepository>();

builder.Services.AddTransient<ISchoolYearService, SchoolYearService>();
builder.Services.AddTransient<ISchoolYearRepository, SchoolYearRepository>();

builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddTransient<IStudentRepository, StudentRepository>();

builder.Services.AddTransient<IStuRewardService, StuRewardService>();
builder.Services.AddTransient<IStuRewardRepository, StuRewardRepository>();

builder.Services.AddTransient<IStudyProgressService, StudyProgressService>();
builder.Services.AddTransient<IStudyProgressRepository, StudyProgressRepository>();

builder.Services.AddTransient<IStuRelativeService, StuRelativeService>();
builder.Services.AddTransient<IStuRelativeRepository, StuRelativeRepository>();

builder.Services.AddTransient<IStuStayingService, StuStayingService>();
builder.Services.AddTransient<IStuStayingRepository, StuStayingRepository>();

builder.Services.AddTransient<IStuDisciplineService, StuDisciplineService>();
builder.Services.AddTransient<IStuDisciplineRepository, StuDisciplineRepository>();


builder.Services.AddTransient<ITeacherRepository, TeacherRepository>();




builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DefaultConnection")
    ));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseAuthorization();

app.MapControllers();

app.Run();
