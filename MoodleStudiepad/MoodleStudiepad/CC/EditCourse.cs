﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodleStudiepad.BU;

namespace MoodleStudiepad.CC {
    public class EditCourse {
        public bool editCourse(Course editedCourse) {
            Course course = new Course();
            return course.editCourse(editedCourse);
        }

    }
}