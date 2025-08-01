﻿using GraphQLDemo.API.Models;
using GraphQLDemo.API.Schema.Queries;
using HotChocolate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDemo.API.Schema.Mutations
{
    public class CourseTypeInput
    {
		[GraphQLNonNullType]
		public string Name { get; set; }
        public Subject Subject { get; set; }
        public Guid InstructorId { get; set; }
    }
}
