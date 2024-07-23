﻿using System;
using Haley.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Haley.Models;
using System.IO;

namespace Haley.Abstractions {
    public interface IObjectStorageService {
        //Onus of generating the path doesn't lie with the Storage service.
        //We need Store, Fetch, Delete
        Task<SummaryResponse> Upload(ObjectWriteRequest input, Stream file, int bufferSize = 8192);
        Task<StreamResponse> Download(ObjectReadRequest input, bool auto_search_extension = true);
        Task<bool> Delete(ObjectReadRequest input);
        bool Exists(ObjectReadRequest input);
        long GetSize(ObjectReadRequest input);
        Task<DirectoryInfoResponse> GetInfo(ObjectReadRequest input);
        Task<StorageSummary> CreateRepository(ObjectWriteRequest input);
        Task<bool> DeleteRepository(ObjectReadRequest input, bool recursive);
    }
}