﻿using System;
using System.Collections.Generic;
using System.Text;
using Mapsui.Providers;

namespace Mapsui.Samples.Common.ExtensionMethods
{
    public static class FeatureExtensions
    {
        public static string ToDisplayText(this IEnumerable<KeyValuePair<string, IEnumerable<IGeometryFeature>>> featureInfos)
        {
            var result = new StringBuilder();

            foreach (var layer in featureInfos)
            {
                result.Append(layer.Key);
                result.Append( Environment.NewLine);
                foreach (var feature in layer.Value)
                {
                    result.Append(feature.ToDisplayText());
                }
                result.Append(Environment.NewLine);
            }
            return result.ToString();
        }

        public static string ToDisplayText(this IGeometryFeature feature)
        {
            var result = new StringBuilder();
            foreach (var field in feature.Fields)
                result.Append($"{field}:{feature[field]}");
            return result.ToString();
        }
    }
}