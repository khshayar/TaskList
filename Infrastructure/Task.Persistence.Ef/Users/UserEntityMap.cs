namespace Task.Persistence.Ef.Users;

public class UserEntityMap:IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x=>x.UserName).IsRequired();
        builder.Property(x=>x.Email).IsRequired(false);
        builder.Property(x=>x.Password).IsRequired();
    }
}