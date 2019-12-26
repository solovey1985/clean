using System.Collections.Generic;
using System.IO;
using cleanArchitecture.Application.Common.Interfaces;
using cleanArchitecture.Application.TodoLists.Queries.ExportTodos;
using cleanArchitecture.Infrastructure.Files.Maps;
using CsvHelper;

namespace cleanArchitecture.Infrastructure.Files {
    public class CsvFileBuilder : ICsvFileBuilder {
        public byte[] BuildTodoItemsFile (IEnumerable<TodoItemRecord> records) {
            using (var memoryStream = new MemoryStream ()) {
                using (var streamWriter = new StreamWriter (memoryStream)) {
                    using (var csvWriter = new CsvWriter (streamWriter)) {

                        csvWriter.Configuration.RegisterClassMap<TodoItemRecordMap> ();
                        csvWriter.WriteRecords (records);
                    }
                }

                return memoryStream.ToArray ();
            }
        }
    }
}