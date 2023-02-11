# ASP.NET-SQL-Injection
<br/>
<br/>

The Entity Framework includes an ORM to perform database queries. 
```cs
public User GetUser(string username)
	{
		return _context.Users.Where(x => x.UserName == username).FirstOrDefault();
	}
```
<br/>
<br/>

If the developer for some reason decides to use raw SQL, then the developer can protect from SQL injection by using parameterized queries.
```cs
public User GetUserRawParameterized(string username)
        {
            return _context.Users.FromSqlRaw("SELECT * FROM Users WHERE username = {0}", username).FirstOrDefault();
        }
```
<br/>
<br/>

If the developer for some reason decides to not use the ORM or parameterized queries, then the application may be vulnerable to SQL injection.
```cs
public User GetUserRaw(string username)
	{
		var query = "SELECT * FROM Users WHERE username = '" + username + "'";
		return _context.Users.FromSqlRaw(query).FirstOrDefault();
	}
```
