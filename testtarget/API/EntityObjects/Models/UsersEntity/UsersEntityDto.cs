/*
 * @bot-written
 * 
 * WARNING AND NOTICE
 * Any access, download, storage, and/or use of this source code is subject to the terms and conditions of the
 * Full Software Licence as accepted by you before being granted access to this source code and other materials,
 * the terms of which can be accessed on the Codebots website at https://codebots.com/full-software-licence. Any
 * commercial use in contravention of the terms of the Full Software Licence may be pursued by Codebots through
 * licence termination and further legal action, and be required to indemnify Codebots for any loss or damage,
 * including interest and costs. You are deemed to have accepted the terms of the Full Software Licence on any
 * access, download, storage, and/or use of this source code.
 * 
 * BOT WARNING
 * This file is bot-written.
 * Any changes out side of "protected regions" will be lost next time the bot makes any changes.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using ServersideUsersEntity = Sprinkler.Models.UsersEntity;

namespace APITests.EntityObjects.Models
{
	/// <summary>
	/// this is a user
	/// </summary>
	public class UsersEntityDto
	{
		public Guid Id { get; set; }
		public DateTime Created { get; set; }
		public DateTime Modified { get; set; }
		public String Name { get; set; }


		public UsersEntityDto(UsersEntity model)
		{
			Id = model.Id;
			Created = model.Created;
			Modified = model.Modified;
			Name = model.Name;
		}

		public UsersEntityDto(ServersideUsersEntity model)
		{
			Id = model.Id;
			Created = model.Created;
			Modified = model.Modified;
			Name = model.Name;
		}

		public UsersEntity GetTesttargetUsersEntity()
		{
			return new UsersEntity
			{
				Id = Id,
				Created = Created,
				Modified = Modified,
				Name = Name,
			};
		}

		public ServersideUsersEntity GetServersideUsersEntity()
		{
			return new ServersideUsersEntity
			{
				Id = Id,
				Created = Created,
				Modified = Modified,
				Name = Name,
			};
		}

		public static ServersideUsersEntity Convert(UsersEntity model)
		{
			var dto = new UsersEntityDto(model);
			return dto.GetServersideUsersEntity();
		}

		public static UsersEntity Convert(ServersideUsersEntity model)
		{
			var dto = new UsersEntityDto(model);
			return dto.GetTesttargetUsersEntity();
		}
	}
}