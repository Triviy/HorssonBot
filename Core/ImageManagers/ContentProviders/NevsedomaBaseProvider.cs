﻿namespace Core.ImageManagers.ContentProviders
{
    internal abstract class NevsedomaBaseProvider : IStaticImageProvider
    {
        private const string _schema = "http";
        protected const string _rootUri = "nevsedoma.com.ua";

        protected abstract string RaitingPattern { get; }
        protected abstract string Category { get; }

        public string PostPattern => $"<a.*?class=\"s-img\".*?href=\"(.*?{_rootUri}/index.php[?]newsid=.*?)\">[\\s\\S]*?{RaitingPattern}[\\s\\S]*?</a>";
        public virtual string ImagePattern => $"<img.*?src=\"(.*?{_rootUri}.*?jpg)\".*?/>";

        public string GenerateIndexPageUrl(int page)
        {
            return $"{_schema}://{_rootUri}/index.php?do=cat&category={Category}&cstart={page}";
        }
    }
}
