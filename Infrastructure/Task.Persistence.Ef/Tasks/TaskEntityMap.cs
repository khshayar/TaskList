namespace Task.Persistence.Ef.Tasks;

public class TaskEntityMap:IEntityTypeConfiguration<Entities.Tasks.Task>
{
    public void Configure(EntityTypeBuilder<Entities.Tasks.Task> builder)
    {
        builder.ToTable("Tasks");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Titel).IsRequired();
        builder.Property(x => x.Description).IsRequired(false);
        builder.Property(x=>x.StartDate).IsRequired(false);
        builder.Property(x=>x.EndDate).IsRequired(false);
        builder.Property(x => x.DoIt).IsRequired(false);
        builder.HasOne(x=>x.User).WithMany(x=>x.Tasks)
            .HasForeignKey(x=>x.UserId);
        builder.HasOne(x=>x.Category).WithMany(x=>x.Tasks)
            .HasForeignKey(x=>x.CategoryId);
    }
}