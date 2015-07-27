using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using TODO_List.Models;

namespace TODO_List.Controllers
{
    public class TaskController : ApiController
    {
        private static List<Tasks> tasks = new List<Tasks>()
        {
            new Tasks {id = 1, theme = "Программирование", description = "Изучение WEB API", resolved = false, date = "27.07.2015" },
            new Tasks {id = 2, theme = "Эконом-эксперт", description = "Обновить базу Зауру", resolved = false, date = "28.07.2015" },
            new Tasks {id = 3, theme = "Программирование", description = "Изучение NodeJs", resolved = false, date = "28.07.2015" },
            new Tasks {id = 4, theme = "Тестирование", description = "Видеоуроки по тестированию", resolved = false, date = "28.07.2015" }
        };

        // GET api/values
        public IEnumerable<Tasks> Get()
        {
            return tasks;
        }

        // GET api/values/5
        public Tasks Get(int id)
        {
            var task = tasks.FirstOrDefault((p) => p.id == id);
            return task;
        }

        [HttpPost]
        public void PostTask([FromBody] Tasks p)
        {
            tasks.Add(p);
        }

        // PUT api/values/5
        [HttpPut]
        public HttpResponseMessage PutTask(int id, [FromBody] Tasks p)
        {
            Tasks pro = tasks.Find(pr => pr.id == id);

            if (pro == null)
                return new HttpResponseMessage(HttpStatusCode.NotFound);

            pro.theme = p.theme;
            pro.description = p.description;
            pro.resolved = p.resolved;
            pro.date = p.date;

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            tasks.Remove(tasks.Find(pr => pr.id == id));
        }

    }
}