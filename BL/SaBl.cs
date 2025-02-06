using AutoMapper;
using DL;
using DTO;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Drawing;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Grid;
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading.Tasks;

namespace BL
{
    public class SaBl:ISaBl
    {
        IMapper _mapper;
        ISaDl _ISaDl;
        public SaBl(IMapper mapper, ISaDl iSaDl)
        {
            _mapper = mapper;
            _ISaDl = iSaDl;
        }
        public async Task<SaDTO> add(SaDTO saDTO)
        {
            Sa sa = _mapper.Map<Sa>(saDTO);
            Sa saAfterAdd = await _ISaDl.add(sa);
            SaDTO saDTOToReturn = _mapper.Map<SaDTO>(saAfterAdd);
            return saDTOToReturn;
        }

        public async Task<SaDTO> delete(int idSaDTO)
        {
            Sa saAfterDelete = await _ISaDl.delete(idSaDTO);
            SaDTO saDTOToReturn = _mapper.Map<SaDTO>(saAfterDelete);
            return saDTOToReturn;
        }

        public async Task<SaDTO> edit(SaDTO saDTO)
        {
            Sa sa = _mapper.Map<Sa>(saDTO);
            Sa saAfterEdit = await _ISaDl.edit(sa);
            SaDTO saDTOToReturn = _mapper.Map<SaDTO>(saAfterEdit);
            return saDTOToReturn;
        }

        public async Task<List<SaDTO>> getAll()
        {
            List<Sa> allSa = await _ISaDl.getAll();
            List<SaDTO> allSaDTOToReturn = _mapper.Map<List<Sa>, List<SaDTO>>(allSa);
            return allSaDTOToReturn;
        }

        public async Task<SaDTO> getById(int idSaDTO)
        {
            Sa sa = await _ISaDl.getById(idSaDTO);
            SaDTO saDTOToReturn = _mapper.Map<SaDTO>(sa);
            return saDTOToReturn;
        }

        public async Task<Form> sendEmail(Form saPdf)
        {
            //try
            //{
            //    string[] array = saPdf.File.Split(',');
            //    string path = "D:\\Zir\\Zirchemed\\wooo.pdf";
            //    File.WriteAllBytes(path, Convert.FromBase64String(array[1]));
            //}
            //catch (Exception ex)
            //{

            //    saPdf.File= ex.Message;
            //}
            return new Form();
            
            
        }
    }
}