static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        var idPart = id.HasValue ? $"[{id}] - " : null;
        var departmentPart = string.IsNullOrEmpty(department) ? "OWNER" : $"{department.ToUpper()}";
        return $"{idPart}{name} - {departmentPart}";
    }
}
