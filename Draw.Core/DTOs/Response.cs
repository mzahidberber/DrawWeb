using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Draw.Core.DTOs;

public class Response<T>
	where T : class
{
	public T data { get; set; }
	public int statusCode { get; set; }
	[JsonIgnore]
	public bool IsSuccesful { get; private set; }
	public ErrorDTO error { get; set; }

	public static Response<T> Success(T data, int statusCode)
	{
		return new Response<T> { data = data, statusCode = statusCode, IsSuccesful = true };
	}

	public static Response<T> Success(int statusCode)
	{
		return new Response<T> { data = default, statusCode = statusCode, IsSuccesful = true };
	}

	public static Response<T> Fail(ErrorDTO error, int statusCode)
	{
		return new Response<T> { error = error, statusCode = statusCode, IsSuccesful = false };
	}

	public static Response<T> Fail(string errorMessage, int statusCode, bool isShow)
	{
		var errorDto = new ErrorDTO(errorMessage, isShow);
		return new Response<T> { error = errorDto, statusCode = statusCode, IsSuccesful = false };
	}
}
