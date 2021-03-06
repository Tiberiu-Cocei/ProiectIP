﻿namespace Gradeio.Quiz.WebApi.Mappers
{
    public static class AutoMapperConfig
    {
        /// <summary>
        ///     Initializes the <see cref="AutoMapper" /> configurations.
        /// </summary>
        public static void Initialize()
        {
            AutoMapper.Mapper.Reset();
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.AddProfile<QuizMapperProfiler>();
                cfg.AddProfile<QuestionMapperProfiler>();
            });
        }
    }
}