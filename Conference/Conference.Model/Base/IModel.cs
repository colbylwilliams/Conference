using System;

namespace Conference.Model
{
	/// <summary>
	/// Model Specifying the Id (or Primary Key) of the model class is of type <c>int</c>
	/// This Interface should only be used on top-level model classes.
	/// </summary>
	public interface IModelInt
	{
		int Id { get; set; }
	}

	/// <summary>
	/// Model Specifying the Id (or Primary Key) of the model class is of type <c>Guid</c>
	/// This Interface should only be used on top-level model classes.
	/// </summary>
	public interface IModelGuid
	{
		Guid Id { get; set; }
	}

	/// <summary>
	/// Model Specifying the Id (or Primary Key) of the model class is of type <c>string</c>
	/// This Interface should only be used on top-level model classes.
	/// </summary>
	public interface IModelString
	{
		string Id { get; set; }
	}
}
