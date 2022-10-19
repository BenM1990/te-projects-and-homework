﻿using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            Project project = null;

            using (SqlConnection projectConnection = new SqlConnection(connectionString))
            {
                projectConnection.Open();

                SqlCommand projectCommand = new SqlCommand("SELECT project_id, name, from_date, to_date FROM project WHERE project_id = @project_id;", projectConnection);
                projectCommand.Parameters.AddWithValue("@project_id", projectId);

                SqlDataReader projectReader = projectCommand.ExecuteReader();

                if (projectReader.Read())
                {
                    project = CreateProjectFromReader(projectReader);
                }
            }


            return project;
        }

        public IList<Project> GetAllProjects()
        {
            IList<Project> projects = new List<Project>();
            using (SqlConnection projectConnection = new SqlConnection(connectionString))
            {
                projectConnection.Open();
                SqlCommand projectCommand = new SqlCommand("SELECT * FROM project", projectConnection);


                SqlDataReader reader = projectCommand.ExecuteReader(); // exectue the select query

                //create park object(s) from the data comming back from the reader
                while (reader.Read())
                {
                    Project project = CreateProjectFromReader(reader);
                    projects.Add(project);
                }
            }
            return projects;
        }

        public Project CreateProject(Project newProject)
        {
            int newProjectId;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO project (name, from_date, to_date) " +
                                                "OUTPUT INSERTED.project_id " +
                                                "VALUES (@name, @from_date, @to_date);", conn);
                cmd.Parameters.AddWithValue("@name", newProject.Name);
                cmd.Parameters.AddWithValue("@from_date", newProject.FromDate);
                cmd.Parameters.AddWithValue("@to_date", newProject.ToDate);
                

                newProjectId = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return GetProject(newProjectId);
        }

        public void DeleteProject(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM project_employee WHERE project_id = @project_id;", conn);
                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.ExecuteNonQuery();

                SqlCommand secondCmd = new SqlCommand("DELETE FROM timesheet WHERE project_id = @project_id;", conn);
                secondCmd.Parameters.AddWithValue("@project_id", projectId);
                secondCmd.ExecuteNonQuery();

                SqlCommand thirdCmd = new SqlCommand("DELETE FROM project WHERE project_id = @project_id;", conn);
                thirdCmd.Parameters.AddWithValue("@project_id", projectId);
                thirdCmd.ExecuteNonQuery();
            }
        }

        private Project CreateProjectFromReader(SqlDataReader reader)
        {
            Project project = new Project();
            project.ProjectId = Convert.ToInt32(reader["project_id"]);
            project.Name = Convert.ToString(reader["name"]);
            project.FromDate = Convert.ToDateTime(reader["from_date"]);
            project.ToDate = Convert.ToDateTime(reader["to_date"]);

            return project;
        }

    }
}
